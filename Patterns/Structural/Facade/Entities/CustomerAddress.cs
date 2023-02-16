namespace Patterns.Structural.Facade.Entities
{
    public class CustomerAddress
    {
        public int CustomerId { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string TownOrCity { get; set; }
        public string Country { get; set; }
        public int PostCode { get; set; }

        public override string ToString() => $"Address: {StreetNumber} {StreetName}, {Suburb}, {TownOrCity} {PostCode}, {Country}";
    }
}
