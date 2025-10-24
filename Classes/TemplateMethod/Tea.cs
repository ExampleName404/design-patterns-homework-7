using System;

namespace DesignPatternsHomework.TemplateMethod
{
    public class Tea : Beverage
    {
        protected override void BrewOrSteep()
        {
            Console.WriteLine("Steeping the tea leaves...");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon...");
        }
    }
}
