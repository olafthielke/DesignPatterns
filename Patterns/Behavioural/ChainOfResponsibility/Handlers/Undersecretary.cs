using System;
using Patterns.Behavioural.ChainOfResponsibility.Incidents;

namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
    public class Undersecretary : EscalatingHandler
    {
        public override string ToString() => "Undersecretary";

        public Undersecretary(IHandler superior)
            : base(superior)
        { }


        public override void Handle(Incident incident)
        {
            if (incident is TariffNegotiation)
            {
                LogCanHandle(incident);
                // TODO: Code to handle this incident type.
            }
            else
            {
                LogCannotHandle(incident);
                // Escalate to superior!
                Escalate(incident);
            }
        }
    }
}
