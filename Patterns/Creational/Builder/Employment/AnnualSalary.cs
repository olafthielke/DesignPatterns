using System;

namespace Patterns.Creational.Builder.Employment
{
    public class AnnualSalary : Compensation
    {
        public int AnnualSalaryAmount { get; }

        public AnnualSalary(int annualSalaryAmount,
            PaymentFrequency paymentFrequency = PaymentFrequency.Monthly)
        {
            AnnualSalaryAmount = annualSalaryAmount;
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
            return AnnualSalaryAmount / AverageWeeksInYear;
        }

        protected override decimal CalcMonthlyPayment()
        {
            return AnnualSalaryAmount / MonthsInYear;
        }
    }
}
