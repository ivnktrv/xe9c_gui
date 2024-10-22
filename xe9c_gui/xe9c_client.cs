using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using xe9c_gui;

namespace xe9c_gui;

public class Xe9c_client
{
    private string _clientName = "None";
    private string _ip = "0.0.0.0";
    private int _port = 0;

    public string ClientName
    {
        get => _clientName;
        private set { if (value != null) _clientName = value; }
    }
    public string IP
    {
        get => _ip;
        private set { if (value != null) _ip = value; }
    }
    public int Port
    {
        get => _port;
        private set { if (value != null) _port = value; }
    }

    public Xe9c_client() { }

    public Xe9c_client(string clientName, string ip, int port)
    {
        _clientName = clientName;
        _ip = ip;
        _port = port;
    }

    public string ConnectionInfo()
    {
        return $"### CONNECTION INFO ###\n\nName: {_clientName}\nIP: {_ip}\nPort: {_port}";
    }

    public Socket ConnectToGateway()
    {
        IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(_ip), _port);
        Socket __socket = new Socket(
            AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        __socket.Connect(ipEndPoint);

        return __socket;
    }

    public void ReceiveMsg(Socket __socket, RichTextBox box)
    {
        while (true)
        {
            byte[] getMsg = new byte[2048];
            __socket.Receive(getMsg);
            box.Text += $"\n{Encoding.UTF8.GetString(getMsg)}";
            box.SelectionStart = box.Text.Length;
            box.ScrollToCaret();
        }
    }

    public void SendMsg(Socket __socket, string message)
    {
        byte[] getMsg = Encoding.UTF8.GetBytes(message);
        __socket.Send(getMsg);
    }
}
/*
...
line 98
line 99
line 100 to erase
 
*/