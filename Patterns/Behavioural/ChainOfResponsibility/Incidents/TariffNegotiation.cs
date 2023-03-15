namespace Patterns.Behavioural.ChainOfResponsibility.Incidents
{
    public class TariffNegotiation : Incident
    {
        public override int Severity => 3;

        public override string ToString() => "Tariff Negotiation";
    }
}
