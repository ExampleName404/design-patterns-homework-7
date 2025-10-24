using System;

namespace DesignPatternsHomework.Command
{
    public class Thermostat
    {
        public double Temperature { get; private set; }
        public Thermostat(double initialTemperature = 20.0)
        {
            Temperature = initialTemperature;
        }
        public void Increase(double amount)
        {
            Temperature += amount;
            Console.WriteLine($"Thermostat increased by {amount} degrees. Current: {Temperature:F1}°C");
        }
        public void Decrease(double amount)
        {
            Temperature -= amount;
            Console.WriteLine($"Thermostat decreased by {amount} degrees. Current: {Temperature:F1}°C");
        }
    }
}
