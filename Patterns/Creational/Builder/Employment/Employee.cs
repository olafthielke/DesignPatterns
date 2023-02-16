using System.Collections.Generic;

namespace Patterns.Creational.Builder.Employment
{
    public abstract class Employee
    {
        public IList<Perk> Perks { get; } = new List<Perk>();
        public Compensation Compensation { get; }

        protected Employee(Compensation compensation)
        {
            Compensation = compensation;
        }


        public Employee AddPerk(Perk perk)
        {
            Perks.Add(perk);

            return this;
        }

        public decimal NextPayAmount()
        {
            return Compensation.NextPayAmount();
        }
    }
}
