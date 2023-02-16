using System;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator.Logging
{
    public class ConsoleLogger : Logger
    {
        public override Task Log(string message)
        {
            Console.WriteLine(message);
            return Task.CompletedTask;
        }
    }
}
