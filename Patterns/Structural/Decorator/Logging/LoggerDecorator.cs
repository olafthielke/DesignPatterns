namespace Patterns.Structural.Decorator.Logging
{
    public abstract class LoggerDecorator : Logger
    {
        protected Logger Logger { get; }

        protected LoggerDecorator(Logger logger)
        {
            Logger = logger;
        }
    }
}
