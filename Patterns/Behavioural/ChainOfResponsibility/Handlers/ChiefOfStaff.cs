using System;
using Patterns.Behavioural.ChainOfResponsibility.Incidents;

namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
    public class ChiefOfStaff : EscalatingHandler
    {
        public override string ToString() => "Chief Of Staff";

        public ChiefOfStaff(IHandler superior)
            : base(superior)
        { }


        public override void Handle(Incident incident)
        {
            if (incident.Severity == 2)
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
