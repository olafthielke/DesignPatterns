using System;
using Patterns.Behavioural.ChainOfResponsibility.Incidents;

namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
    public class TradeRepresentative : EscalatingHandler
    {
        public override string ToString() => "Trade Representative";

        public TradeRepresentative(IHandler superior)
            : base(superior)
        { }

        public override void Handle(Incident incident)
        {
            if (incident.Severity == 4)
            {
                LogCanHandle(incident);
                // TODO: Code to handle this level of severity incident.
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
