using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab
{
    // Паттерн Mediator
    public interface IChatMediator
    {
        void RegisterMember(IChatMember member);
        void SendMessage(string message, IChatMember sender);
    }

    public interface IChatMember
    {
        void ReceiveMessage(string message);
    }

    public class ChatMediator : IChatMediator
    {
        private List<IChatMember> _members = new List<IChatMember>();

        public void RegisterMember(IChatMember member)
        {
            _members.Add(member);
        }

        public void SendMessage(string message, IChatMember sender)
        {
            foreach (var member in _members)
            {
                if (member != sender)
                {
                    member.ReceiveMessage(message);
                }
            }
        }
    }

    public class ChatUser : IChatMember
    {
        private string _name;
        private IChatMediator _mediator;

        public ChatUser(string name, IChatMediator mediator)
        {
            _name = name;
            _mediator = mediator;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{_name} отправляет сообщение: {message}");
            _mediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{_name} получил сообщение: {message}");
        }
    }
}
