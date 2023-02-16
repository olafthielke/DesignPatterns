namespace Patterns.Creational.Builder.Employment
{
    public class HourlyManagerBuilder : EmployeeBuilder
    {
        public Employee Build(decimal hourlyWage, decimal hoursWorked)
        {
            var compensation = new HourlyWage(hourlyWage, hoursWorked);

            return new Manager(compensation)
                .AddPerk(new CompanyCar());
        }
    }
}
