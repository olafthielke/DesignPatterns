namespace Patterns.Creational.Builder.Employment
{
    public class WorkerBuilder
    {
        public Employee Build(decimal hourlyWage, decimal hoursWorked)
        {
            var compensation = new HourlyWage(hourlyWage, hoursWorked);

            return new Worker(compensation);
        }
    }
}
