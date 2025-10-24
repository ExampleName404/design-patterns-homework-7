namespace DesignPatternsHomework.Mediator
{
    public interface IMediator
    {
        void Register(User user);
        void SendMessage(string from, string message);
        void SendPrivate(string from, string to, string message);
    }
}

