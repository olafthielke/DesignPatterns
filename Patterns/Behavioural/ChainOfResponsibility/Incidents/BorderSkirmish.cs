namespace Patterns.Behavioural.ChainOfResponsibility.Incidents
{
    public class BorderSkirmish : Incident
    {
        public override int Severity => 2;

        public override string ToString() => "Border Skirmish";
    }
}
