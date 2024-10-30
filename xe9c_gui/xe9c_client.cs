using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using xe9c_gui;

namespace xe9c_gui;

public class Xe9c_client : IDisposable
{
    private Socket? _gateway = null;
    private string _clientName = "None";
    private string _ip = "0.0.0.0";
    private int _port = 0;
    private bool _windowMinimized = false;
    private bool _disposed = false;
    
    public Socket Gateway
    {
        get => _gateway;
    }
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
    public bool WindowMinimized
    {
        get => _windowMinimized;
        set { _windowMinimized = value; }
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

    public void ConnectToGateway()
    {
        IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(_ip), _port);
        IPAddress ipAddr = IPAddress.Parse(_ip);
        _gateway = new Socket(
            ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        _gateway.Connect(ipEndPoint);
    }

    public void ReceiveMsg(RichTextBox box, NotifyIcon notifyIcon)
    {
        while (true)
        {
            byte[] getMsg = new byte[2048];
            _gateway.Receive(getMsg);
            box.Text += $"\n{Encoding.UTF8.GetString(getMsg)}";
            box.SelectionStart = box.Text.Length;
            box.ScrollToCaret();
            if (_windowMinimized)
            {
                notifyIcon.BalloonTipText = Encoding.UTF8.GetString(getMsg);
                notifyIcon.ShowBalloonTip(5);
            }
        }
    }

    public void SendMsg(string message)
    {
        byte[] getMsg = Encoding.UTF8.GetBytes(message);
        _gateway.Send(getMsg);
    }

    public void SetDefaultValue()
    {
        _gateway = null;
        _clientName = "None";
        _ip = "0.0.0.0";
        _port = 0;
    }

    #region Dispose
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;
        if (disposing)
        {
            _gateway.Close();
            _gateway.Dispose();
            SetDefaultValue();
        }
        _disposed = true;
    }

    ~Xe9c_client()
    {
        Dispose(false);
    }
    #endregion
}
