using System;
using WeChat.Network.Server;

namespace WeChat.Server.Program
{
    public class Program
    {
        // Ponto de entrada
        public static void Main(string[] args)
        {
            ServerConnection serverConnection = new ServerConnection();
            serverConnection.StartConnection();
        }
    }
}