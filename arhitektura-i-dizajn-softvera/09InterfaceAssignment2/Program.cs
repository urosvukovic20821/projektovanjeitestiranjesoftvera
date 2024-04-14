using System;
using _09InterfaceAssignment2.Interfaces;
using _09InterfaceAssignment2.Models;
using _09InterfaceAssignment2.Services;

namespace _09InterfaceAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var message=new MessageType1("Some message subject","Some message body");
            INotificationService notificationService = null;

            notificationService=new EmailService();
            notificationService.Send(message);
            
            notificationService=new SmsService();
            notificationService.Send(message);
            
            notificationService=new PostService();
            notificationService.Send(message);

            Console.ReadLine();
        }
    }
}
