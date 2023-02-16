namespace Patterns.Structural.Facade.Entities
{
    public class CustomerLoyalty
    {
        public int CustomerId { get; set; }
        public int LoyaltyPoints { get; set; }

        public override string ToString() => $"Loyalty: Points = {LoyaltyPoints}";
    }
}
