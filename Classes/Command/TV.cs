using System;

namespace DesignPatternsHomework.Command
{
    public class TV
    {
        public string Location { get; }
        private bool isOn;
        public TV(string location)
        {
            Location = location;
            isOn = false;
        }
        public void On()
        {
            isOn = true;
            Console.WriteLine($"{Location} TV is ON");
        }
        public void Off()
        {
            isOn = false;
            Console.WriteLine($"{Location} TV is OFF");
        }
    }
}
