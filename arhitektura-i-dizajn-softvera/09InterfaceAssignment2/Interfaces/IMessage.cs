using System;

namespace _09InterfaceAssignment2.Interfaces
{
    public interface IMessage
    {
        Guid Id { get; }
        DateTime CreatedAt { get; }
        string Subject { get; }
        string Message { get; }
    }
}