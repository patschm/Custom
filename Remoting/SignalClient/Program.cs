
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace SignalClient
{
    class Program
    {
        static HubConnection connection;

        static void Main(string[] args)
        {
            Configure().Wait();
            SendMessage(); 
            Console.ReadLine();
        }

        private static void SendMessage()
        {
            do
            {
                Console.WriteLine("Wat wilt u zeggen?");
                string text = Console.ReadLine();
                connection.SendAsync("RoeptUMaar", text);
            }
            while (true);
           
        }

        private static async Task Configure()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/zeur")
                .Build();
            
            connection.On<string>("toeter", msg => {
                Console.WriteLine(msg);
                Console.WriteLine("==========================");
            });
            await connection.StartAsync();
        }
    }
}
