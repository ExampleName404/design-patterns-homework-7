using System;

namespace DesignPatternsHomework.Command
{
    public class Light
    {
        public string Location { get; }
        private bool isOn;
        public Light(string location)
        {
            Location = location;
            isOn = false;
        }
        public void On()
        {
            isOn = true;
            Console.WriteLine($"{Location} light is ON");
        }
        public void Off()
        {
            isOn = false;
            Console.WriteLine($"{Location} light is OFF");
        }
    }
}
