namespace DesignPatternsHomework.Command
{
    public class ThermostatIncreaseCommand : ICommand
    {
        private readonly Thermostat _thermostat;
        private readonly double _amount;
        public ThermostatIncreaseCommand(Thermostat thermostat, double amount)
        {
            _thermostat = thermostat;
            _amount = amount;
        }
        public void Execute()
        {
            _thermostat.Increase(_amount);
        }
        public void Undo()
        {
            _thermostat.Decrease(_amount);
        }
    }
}

