namespace Patterns.Behavioural.NullObject
{
    public class DoNotLogger : ILogger
    {
        public void Log(string message)
        {
            // Doesn't Log!
        }
    }
}
