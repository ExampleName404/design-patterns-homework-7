using System;

namespace DesignPatternsHomework.Command
{
    public class Door
    {
        public string Location { get; }
        private bool isOpen;
        public Door(string location)
        {
            Location = location;
            isOpen = false;
        }
        public void Open()
        {
            isOpen = true;
            Console.WriteLine($"{Location} door is OPEN");
        }
        public void Close()
        {
            isOpen = false;
            Console.WriteLine($"{Location} door is CLOSED");
        }
    }
}
