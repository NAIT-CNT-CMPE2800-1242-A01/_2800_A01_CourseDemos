using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SocketServer
{
    public partial class Server : Form
    {
        Socket listenerSocket = null;
        Socket connectedSocket = null;

        Thread thread = null;

        public Server()
        {
            InitializeComponent();
        }

        private void UI_Connect_Btn_Click(object sender, EventArgs e)
        {
            listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);

            listenerSocket.Bind(new IPEndPoint(IPAddress.Any, 1666));

            listenerSocket.Listen(5);

            listenerSocket.BeginAccept(cbBeginAccept, null);
        }

        private void cbBeginAccept(IAsyncResult result)
        {
            try
            {
                connectedSocket = listenerSocket.EndAccept(result);

                StartReceive();

                Console.WriteLine($"{nameof(cbBeginAccept)}: Connection formed!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(cbBeginAccept)}: Try reconnecting... {ex.Message}");
            }
        }

        private void StartReceive()
        {
            thread = new Thread(ThreadReceive);
            thread.IsBackground = true;
            thread.Start();
        }

        private void ThreadReceive()
        {
            while (true)
            {
                byte[] bytes = new byte[20000];

                try
                {
                    int receivedBytes = connectedSocket.Receive(bytes);

                    if (receivedBytes == 0)
                    {
                        // soft disco
                        Invoke(new Action(() => Text = "Soft Disco!"));
                        return;
                    }

                    string message = Encoding.UTF8.GetString(bytes, 0, receivedBytes);
                    Invoke(new Action(() => Text = message));
                }
                catch (Exception ex)
                {
                    // hard disco
                    Invoke(new Action(() => Text = $"Hard Disco! {ex.Message}"));
                    return;
                }
            }
        }
    }
}
