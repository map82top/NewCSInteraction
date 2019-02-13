using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSInteraction;
using CSInteraction.Client;
using CSInteraction.ProgramMessage;

namespace TemplateClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClient Client = new BaseClient("127.0.0.1",1500);
            Client.EventNewMessage += GetMessage;
            Client.EventEndSession += HandlerEndSession;
            if (Client.ConnectToServer())
            {
                Console.WriteLine("Соединение с сервером прошло успешно");
                for (int i = 0;i < 5 ;i++)
                {
                    /* Console.WriteLine("Введите сообщение: ");
                     IMessage msg = new TextMessage(Console.ReadLine());
                     if (Client.SendMessage(msg))
                     {
                         Console.WriteLine("Сообщение отправлено");
                     }
                     else { Console.WriteLine("Неудалось отправить сообщение"); }
                     */
                    Client.SendMessage(new TextMessage("Тестовое сообщение"));
                }
            }
            else
            {
                Console.WriteLine("Ошибка соединения с сервером");
            }
        }
        static void GetMessage(IMessage msg)
        {
            Console.WriteLine("Получено сообщени от сервера: " + (msg as TextMessage).Text);
        }
        static void HandlerEndSession()
        {
            Console.WriteLine("Соединение с сервером разорвано");
        }
    }
    
}
