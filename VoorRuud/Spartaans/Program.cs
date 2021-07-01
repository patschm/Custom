using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Spartaans
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket s1 = new Socket(SocketType.Stream, ProtocolType.Tcp);
            s1.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.KeepAlive, true);

            s1.Listen();

           // Task.Factory.FromAsync(s1.BeginReceive(), s1.EndReceive());

           
        }
    }
}
