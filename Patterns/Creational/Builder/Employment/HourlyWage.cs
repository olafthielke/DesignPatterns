using System;

namespace Patterns.Creational.Builder.Employment
{
    public class HourlyWage : Compensation
    {
        public decimal HourlyWageAmount { get; }
        public decimal WeeklyHoursWorked { get; }

        public HourlyWage(decimal hourlyWageAmount, decimal weeklyHoursWorked,
            PaymentFrequency paymentFrequency = PaymentFrequency.Weekly)
        {
            HourlyWageAmount = hourlyWageAmount;
            WeeklyHoursWorked = weeklyHoursWorked;
            PaymentFrequency = paymentFrequency;
        }

        public override decimal NextPayAmount()
        {
            if (IsWeeklyPayment())
                return CalcWeeklyPayment();

            if (IsMonthlylyPayment())
                return CalcMonthlyPayment();

            throw new InvalidOperationException("Unknown Payment Frequency!");
        }

        protected override decimal CalcWeeklyPayment()
        {
            return HourlyWageAmount * WeeklyHoursWorked;
        }

        protected override decimal CalcMonthlyPayment()
        {
            return HourlyWageAmount * WeeklyHoursWorked * AverageWeeksInMonth;
        }
    }
}
