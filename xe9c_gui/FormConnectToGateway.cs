using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xe9c_gui;

public partial class FormConnectToGateway : Form
{
    public FormConnectToGateway()
    {
        InitializeComponent();
    }

    private void FormLogin_Load(object sender, EventArgs e)
    {
        
    }

    private void textBoxInputClientName_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxInputIP_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxInputPort_TextChanged(object sender, EventArgs e)
    {

    }

    private void buttonConnect_Click(object sender, EventArgs e)
    {
        Xe9c_client? client;
        Socket? server;
        FormMain? mainWindow;

        try
        {
            if (textBoxInputClientName.Text.Length > 32)
            {
                MessageBox.Show(
                    "Длина имени не должна превышать 32 символа",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            else if (int.Parse(textBoxInputPort.Text) > 65535)
            {
                MessageBox.Show(
                    "Номер порта не должен превышать 65535",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                client = new(
                    textBoxInputClientName.Text,
                    textBoxInputIP.Text,
                    int.Parse(textBoxInputPort.Text)
                );
                mainWindow = new(client);
                mainWindow.Show();
                this.Hide();
                mainWindow.FormClosed += (s, args) => this.Show();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
