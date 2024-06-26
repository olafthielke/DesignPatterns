﻿using System;
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
            if (incident.Severity == 3)
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
