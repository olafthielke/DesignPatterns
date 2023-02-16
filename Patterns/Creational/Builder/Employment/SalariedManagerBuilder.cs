namespace Patterns.Creational.Builder.Employment
{
    public class SalariedManagerBuilder : EmployeeBuilder
    {
        public Employee Build(int salary)
        {
            var compensation = new AnnualSalary(salary);

            return new Manager(compensation)
                .AddPerk(new CompanyCar())
                .AddPerk(new RetirementPlan());
        }
    }
}
