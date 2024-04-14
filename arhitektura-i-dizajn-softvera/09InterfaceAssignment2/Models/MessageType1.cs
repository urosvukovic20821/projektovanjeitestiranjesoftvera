using System;
using _09InterfaceAssignment2.Extensions;
using _09InterfaceAssignment2.Interfaces;

namespace _09InterfaceAssignment2.Models
{
    public class MessageType1 : IMessage
    {
        public Guid Id { get; }
        public DateTime CreatedAt { get; }
        public string Subject { get; }
        public string Message { get; }

        public MessageType1(Guid id,string subject, string message)
        {
            Id = id;
            CreatedAt = DateTime.UtcNow;
            subject.ThrowIfEmptyOrNull(nameof(subject));
            Subject = subject;
            message.ThrowIfEmptyOrNull(nameof(message));
            Message = message;
        }

        public MessageType1(string subject, string message)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            subject.ThrowIfEmptyOrNull(nameof(subject));
            Subject = subject;
            message.ThrowIfEmptyOrNull(nameof(message));
            Message = message;
        }

        public override string ToString()
        {
            return $"This is message of type {nameof(MessageType1)} with Id:{Id} created {CreatedAt:dd.MM.yyyy} Subject: {Subject} Body: {Message} \n\n";
        }
    }
}