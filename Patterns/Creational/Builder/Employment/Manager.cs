using System;

namespace Patterns.Creational.Builder.Employment
{
    public class Manager : Employee
    {
        public Manager(Compensation compensation)
            : base(compensation)
        { }
    }
}
