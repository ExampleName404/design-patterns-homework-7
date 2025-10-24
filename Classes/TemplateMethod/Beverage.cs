using System;

namespace DesignPatternsHomework.TemplateMethod
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewOrSteep();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }
        protected void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }
        protected abstract void BrewOrSteep();
        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup...");
        }
        protected abstract void AddCondiments();
        // Hook
        protected virtual bool CustomerWantsCondiments() => true;
    }
}
