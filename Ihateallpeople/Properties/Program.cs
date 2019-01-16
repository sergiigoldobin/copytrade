using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ihateallpeople
{
    class Program
    {
        static void Main(string[] args)
        {

            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
            ProtocolType.Udp);

            IPAddress serverAddr = IPAddress.Parse("127.0.0.1");
           
            IPEndPoint endPoint = new IPEndPoint(serverAddr, 5394);

            string text = "Hello";
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);

            sock.SendTo(send_buffer, endPoint);


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
