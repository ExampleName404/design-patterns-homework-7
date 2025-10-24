using System;
using System.Collections.Generic;

namespace DesignPatternsHomework.Command
{
    public class Invoker
    {
        private readonly Stack<ICommand> _history = new Stack<ICommand>();
        public void ExecuteCommand(ICommand command)
        {
            if (command == null) return;
            command.Execute();
            _history.Push(command);
        }
        public void UndoLast()
        {
            if (_history.Count == 0)
            {
                Console.WriteLine("No commands to undo.");
                return;
            }
            var cmd = _history.Pop();
            cmd.Undo();
        }
        public void UndoLastN(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Invalid undo count.");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                if (_history.Count == 0)
                {
                    Console.WriteLine("No more commands to undo.");
                    break;
                }
                var cmd = _history.Pop();
                cmd.Undo();
            }
        }
    }
}
