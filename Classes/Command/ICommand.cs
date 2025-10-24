namespace DesignPatternsHomework.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}

