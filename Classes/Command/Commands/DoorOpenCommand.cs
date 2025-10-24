namespace DesignPatternsHomework.Command
{
    public class DoorOpenCommand : ICommand
    {
        private readonly Door _door;
        public DoorOpenCommand(Door door)
        {
            _door = door;
        }
        public void Execute()
        {
            _door.Open();
        }
        public void Undo()
        {
            _door.Close();
        }
    }
}

