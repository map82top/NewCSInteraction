using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSInteraction.Server;

namespace TemplateServer
{
    static class Program
    {
        public static Server ObjectServer;
        static void Main(string[] args)
        {
            Server ObjectServer = new Server("127.0.0.1",1500, new ControlerClient());
            if (ObjectServer.StartServer())
            {
                Console.WriteLine("Сервер запущен");
            }
            else Console.WriteLine("Ошибка запуска сервера");
            for (; ; )
            {
            }
        }
    }
}
