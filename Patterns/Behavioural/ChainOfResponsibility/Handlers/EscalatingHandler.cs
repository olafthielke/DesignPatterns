using Patterns.Behavioural.ChainOfResponsibility.Incidents;
using System;

namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
    public abstract class EscalatingHandler : IHandler
    {
        protected IHandler Superior { get; set; }

        protected EscalatingHandler(IHandler superior)
        {
            Superior = superior;
        }

        public virtual void Escalate(Incident incident)
        {
            Superior.Handle(incident);
        } 

        public abstract void Handle(Incident incident);


        public void LogCanHandle(Incident incident)
        {
            Console.WriteLine($"{this} handles {incident}.");
        }

        public void LogCannotHandle(Incident incident)
        {
            Console.WriteLine($"{this} doesn't handle {incident}. => Escalate.");
        }
    }
}
