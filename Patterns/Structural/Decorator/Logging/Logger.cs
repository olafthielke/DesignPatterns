using System.Threading.Tasks;

namespace Patterns.Structural.Decorator.Logging
{
    public abstract class Logger
    {
        public abstract Task Log(string message);
    }
}
