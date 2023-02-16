namespace Patterns.Creational.Builder.Employment
{
    public abstract class Compensation
    {
        protected const decimal DaysInWeek = 7;
        protected const decimal MonthsInYear = 12;
        protected const decimal AverageDaysInYear = 365.25m;
        protected const decimal AverageDaysInMonth = AverageDaysInYear / MonthsInYear;
        protected const decimal AverageWeeksInMonth = AverageDaysInMonth / DaysInWeek;
        protected const decimal AverageWeeksInYear = AverageDaysInYear / DaysInWeek;

        public PaymentFrequency PaymentFrequency { get; protected set; }

        public abstract decimal NextPayAmount();
        protected abstract decimal CalcWeeklyPayment();
        protected abstract decimal CalcMonthlyPayment();


        protected bool IsWeeklyPayment()
        {
            return PaymentFrequency == PaymentFrequency.Weekly;
        }

        protected bool IsMonthlylyPayment()
        {
            return PaymentFrequency == PaymentFrequency.Monthly;
        }
    }
}
