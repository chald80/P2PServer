using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace P2PServer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is the server");
            TcpListener listener = new TcpListener(IPAddress.Loopback, 2121);
            listener.Start();
            Console.WriteLine("Server ready");

            while (true)
            {

                TcpClient socket = listener.AcceptTcpClient();
                Console.WriteLine("Incoming client");


                Task.Run(() =>
                {
                    DoClient(socket);
                });
            }
        }





        private static void DoClient(TcpClient socket)
        {
            NetworkStream ns = socket.GetStream();
            StreamReader reader = new StreamReader(ns);
            StreamWriter writer = new StreamWriter(ns);
            while (true)
            {
                string message1 = reader.ReadLine();
                string message2 = reader.ReadLine();
                Console.WriteLine("Server received: " + message1);
                Console.WriteLine("Server received: " + message2);





            }
        }

    }
}
