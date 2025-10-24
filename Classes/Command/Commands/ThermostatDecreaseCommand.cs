namespace DesignPatternsHomework.Command
{
    public class ThermostatDecreaseCommand : ICommand
    {
        private readonly Thermostat _thermostat;
        private readonly double _amount;
        public ThermostatDecreaseCommand(Thermostat thermostat, double amount)
        {
            _thermostat = thermostat;
            _amount = amount;
        }
        public void Execute()
        {
            _thermostat.Decrease(_amount);
        }
        public void Undo()
        {
            _thermostat.Increase(_amount);
        }
    }
}

