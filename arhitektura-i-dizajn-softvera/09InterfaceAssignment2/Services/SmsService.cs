using System;
using _09InterfaceAssignment2.Interfaces;

namespace _09InterfaceAssignment2.Services
{
    public class SmsService : INotificationService
    {
        public void Send(IMessage message)
        {
            Console.WriteLine($"Sending message by using {nameof(SmsService)} Message details:{message}");
        }
    }
}