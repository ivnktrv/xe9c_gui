using System.Net.Sockets;


namespace xe9c_gui;

public partial class Form1 : Form
{
    Xe9c_client client;
    Socket server;

    public Form1()
    {
        InitializeComponent();
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void buttonSend_Click(object sender, EventArgs e)
    {
        outTextBox.Text += $"\n({client.ClientName})>"+inputBox.Text;
        client.SendMsg(server, $"({client.ClientName})> {inputBox.Text}");
        
    }


    private void Form1_Load(object sender, EventArgs e)
    {
        try
        {
            string[] args = Environment.GetCommandLineArgs();
            client = new(args[1], args[2], int.Parse(args[3]));
            server = client.ConnectToGateway();
            outTextBox.Text = $"##### CONNECTED #####\nYour client name: {client.ClientName}\n- - - - - - - -";
            Task.Run(() => client.ReceiveMsg(server, outTextBox));
        }
        catch (Exception ex)
        {
            outTextBox.Text = "ERROR: "+ex.Message;
        }
    }
}
