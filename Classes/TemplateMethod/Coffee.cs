using System;

namespace DesignPatternsHomework.TemplateMethod
{
    public class Coffee : Beverage
    {
        private readonly bool _wantsCondiments;
        public Coffee(bool wantsCondiments = true)
        {
            _wantsCondiments = wantsCondiments;
        }
        protected override void BrewOrSteep()
        {
            Console.WriteLine("Brewing the coffee grounds...");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding milk and sugar...");
        }
        protected override bool CustomerWantsCondiments() => _wantsCondiments;
    }
}
