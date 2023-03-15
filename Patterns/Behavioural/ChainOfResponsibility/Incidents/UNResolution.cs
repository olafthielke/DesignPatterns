namespace Patterns.Behavioural.ChainOfResponsibility.Incidents
{
    public class UNResolution : Incident
    {
        public override int Severity => 2;

        public override string ToString() => "UN Resolution";
    }
}
