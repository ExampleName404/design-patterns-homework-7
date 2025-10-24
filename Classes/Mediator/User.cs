using System;
namespace DesignPatternsHomework.Mediator
{
    public class User
    {
        public string Name { get; }
        private IMediator? _mediator;
        public User(string name)
        {
            Name = name;
            _mediator = null;
        }
        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void Send(string message)
        {
            if (_mediator == null)
            {
                Console.WriteLine($"{Name} is not part of a chat. Message not sent.");
                return;
            }
            _mediator.SendMessage(Name, message);
        }
        public void SendPrivate(string to, string message)
        {
            if (_mediator == null)
            {
                Console.WriteLine($"{Name} is not part of a chat. Private message not sent.");
                return;
            }
            _mediator.SendPrivate(Name, to, message);
        }
        public void Receive(string from, string message)
        {
            Console.WriteLine($"[{Name}] received from {from}: {message}");
        }
        public void ReceivePrivate(string from, string message)
        {
            Console.WriteLine($"[{Name}] PRIVATE from {from}: {message}");
        }
    }
}
