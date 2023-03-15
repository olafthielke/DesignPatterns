namespace Patterns.Behavioural.ChainOfResponsibility.Incidents
{
    public class War : Incident
    {
        public override int Severity => 1;

        public override string ToString() => "War";
    }
}
