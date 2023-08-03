using System;
using System.Collections.Generic;
using WebSocketSharp.Server;

namespace SocketServer
{
    class Program
    {
        public static List<string> allusers = new List<string>() { "Server Dummy User"};
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello! Server is sarting...");
                WebSocketServer server = new WebSocketServer(666);

                //define servers logic
                server.AddWebSocketService<MyServerLogic>("/chatApp");
                server.Start();
                Console.WriteLine("Server started at " + DateTime.Now);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
