using System;
using Patterns.Behavioural.ChainOfResponsibility.Incidents;

namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
    public class ThePresident : IHandler
    {
        public override string ToString() => "The President";


        public void Handle(Incident incident)
        {
            Console.WriteLine($"{this} handles {incident}. The Buck stops here.");
        }
    }
}
