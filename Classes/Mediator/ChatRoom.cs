using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsHomework.Mediator
{
    public class ChatRoom : IMediator
    {
        private readonly List<User> _users = new List<User>();
        public void Register(User user)
        {
            if (!_users.Contains(user))
            {
                _users.Add(user);
                user.SetMediator(this);
                Console.WriteLine($"{user.Name} joined the chat.");
                BroadcastSystemMessage($"{user.Name} has joined the chat.", user.Name);
            }
        }
        public void SendMessage(string from, string message)
        {
            var sender = _users.FirstOrDefault(u => u.Name == from);
            if (sender == null)
            {
                Console.WriteLine($"User '{from}' is not in the chat.");
                return;
            }
            foreach (var user in _users)
            {
                if (user.Name != from)
                {
                    user.Receive(from, message);
                }
            }
        }
        public void SendPrivate(string from, string to, string message)
        {
            var sender = _users.FirstOrDefault(u => u.Name == from);
            if (sender == null)
            {
                Console.WriteLine($"User '{from}' is not in the chat. Cannot send private message.");
                return;
            }
            var recipient = _users.FirstOrDefault(u => u.Name == to);
            if (recipient == null)
            {
                Console.WriteLine($"User '{to}' not found in the chat.");
                return;
            }
            recipient.ReceivePrivate(from, message);
        }
        private void BroadcastSystemMessage(string message, string? exceptName = null)
        {
            foreach (var user in _users)
            {
                if (user.Name != exceptName)
                    user.Receive("System", message);
            }
        }
    }
}
