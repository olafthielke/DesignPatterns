namespace Patterns.Behavioural.ChainOfResponsibility.Incidents
{
    public class TradeDispute : Incident
    {
        public override int Severity => 4;

        public override string ToString() => "Trade Dispute";
    }
}
