using System;
using _09InterfaceAssignment2.Interfaces;

namespace _09InterfaceAssignment2.Services
{
    public class EmailService : INotificationService
    {
        public void Send(IMessage message)
        {
            Console.WriteLine($"Sending message by using {nameof(EmailService)} Message details:{message}");
        }
    }
}