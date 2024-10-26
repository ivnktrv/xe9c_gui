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

    private void FormMain_Load(object sender, EventArgs e)
    {
        Text = $"xe9c ({_client.ClientName})";
        inputBox.Text = "Âàøå ñîîáùåíèå...";
        try
        {
            _server = _client.ConnectToGateway();
            byte[] sendName = Encoding.UTF8.GetBytes(_client.ClientName);
            _server.Send(sendName);
            outTextBox.Text = $"##### ÏÎÄÊËÞ×ÅÍÎ Ê {_client.IP}:{_client.Port} #####\nÂàøå èìÿ: {_client.ClientName}\n- - - - - - - - - - - -";
            Task.Run(() => _client.ReceiveMsg(_server, outTextBox));
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
}