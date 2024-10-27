using System.Diagnostics;
using System.Net.Sockets;
using System.Text;


namespace xe9c_gui;

public partial class FormMain : Form
{
    private Xe9c_client? _client;
    private Socket? _server;

    public FormMain(Xe9c_client client)
    {
        InitializeComponent();
        _client = client;
    }

    private void outTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void inputBox_TextChanged(object sender, EventArgs e)
    {

    }
    /*
    private void FormMain_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) 
        {
            buttonSend.PerformClick();
            inputBox.Clear();
        }
        else if (e.Shift && e.KeyCode == Keys.Enter)
            inputBox.Text += "\n";

    }
    */
    private void buttonSend_Click(object sender, EventArgs e)
    {
        outTextBox.Text += $"\n<{_client.ClientName}> " + inputBox.Text;
        _client.SendMsg(_server, $"<{_client.ClientName}> {inputBox.Text}");
        outTextBox.SelectionStart = outTextBox.Text.Length;
        outTextBox.ScrollToCaret();
        inputBox.SelectAll();
        inputBox.Focus();
    }

    private void FormMain_Resize(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Minimized || this.Visible is false)
            _client.WindowMinimized = true;
        else _client.WindowMinimized = false;
    }

    private void FormMain_Show(object sender, EventArgs e)
    {
        Show();
        WindowState = FormWindowState.Normal;
    }

    private void FormMain_Hide(object sender, EventArgs e)
    {
        Hide();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        Text = $"xe9c ({_client.ClientName})";
        inputBox.Text = "Ваше сообщение...";
        notifyIconNewMsg.Text = $"xe9c ({_client.ClientName})";
        try
        {
            _server = _client.ConnectToGateway();
            byte[] sendName = Encoding.UTF8.GetBytes(_client.ClientName);
            _server.Send(sendName);
            byte[] recvGatewayName = new byte[16];
            _server.Receive(recvGatewayName);
            string getGatewayName = Encoding.UTF8.GetString(recvGatewayName);
            richTextBoxGatewayInfo.Text = "Имя шлюза: " + getGatewayName;
            richTextBoxGatewayInfo.Text += $"\nIP: {_client.IP}\nПорт: {_client.Port}";
            Task.Run(() => _client.ReceiveMsg(_server, outTextBox, notifyIconNewMsg));
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            Close();
        }
    }

    private void buttonDisconnect_Click(object sender, EventArgs e)
    {
        _server.Close();
        Close();
    }

    private void buttonHide_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void labelGithub_Click(object sender, EventArgs e)
    {
        ProcessStartInfo start = new("https://github.com/ivnktrv/xe9c_gui") { UseShellExecute = true };
        Process.Start(start);
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        _server.Close();
    }
}