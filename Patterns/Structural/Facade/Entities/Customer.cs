namespace Patterns.Structural.Facade.Entities
{
    public class Customer
    {
        private CustomerDetails Details { get; }
        private CustomerAddress Address { get; }
        private CustomerLoyalty Loyalty { get; }

        public Customer(CustomerDetails details,
            CustomerAddress address,
            CustomerLoyalty loyalty)
        {
            Details = details;
            Address = address;
            Loyalty = loyalty;
        }

        public override string ToString() => $"\t{Details}.\r\n\t{Address}.\r\n\t{Loyalty}.";


        // Details
        public int CustomerId => Details.CustomerId;
        public string FirstName => Details.FirstName;
        public string LastName => Details.LastName;
        public string EmailAddress => Details.EmailAddress;

        // Address
        public string StreetNumber => Address?.StreetNumber;
        public string StreetName => Address?.StreetName;
        public string Suburb => Address?.Suburb;
        public string TownOrCity => Address?.TownOrCity;
        public string Country => Address?.Country;
        public int? PostCode => Address?.PostCode;

        // Loyalty
        public int? LoyaltyPoints => Loyalty?.LoyaltyPoints;
    }
}
