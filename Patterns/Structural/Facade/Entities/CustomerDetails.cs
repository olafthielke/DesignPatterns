namespace Patterns.Structural.Facade.Entities
{
    public class CustomerDetails
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public override string ToString() => $"Details: (Id: {CustomerId}), {FirstName} {LastName}, {EmailAddress}";
    }
}
