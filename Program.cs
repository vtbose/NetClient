using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sender = new Socket(AddressFamily.InterNetwork,
            //    SocketType.Stream, ProtocolType.Tcp);
            //var remoteEp = new IPEndPoint(IPAddress.Loopback, 6178);
            //sender.Connect(remoteEp);


            var msg = Encoding.ASCII.GetBytes("This is a test<EOF>");
            //var bytesSent = sender.Send(msg);

            //// Data buffer for incoming data.
            //var bytes = new byte[1024];
            //var bytesRec = sender.Receive(bytes);

            //// Release the socket.
            //sender.Shutdown(SocketShutdown.Both);
            //sender.Close();

            const int port = 6178;
            var client = new TcpClient(IPAddress.Loopback.ToString(), port);
            var stream = client.GetStream();
            stream.Write(msg, 0, msg.Length);
            stream.Close();
            client.Close();
        }
    }
}
