using System.IO;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator.Logging
{
    public class DebugToFileLogger : LoggerDecorator
    {
        public DebugToFileLogger(Logger logger)
            : base(logger)
        { }

        public override async Task Log(string message)
        {
            // Other Logger
            await Logger.Log(message);

            // File Logger
            const string FileName = "DebugLog.txt";
            await using var file = new StreamWriter(FileName, append: true);
            await file.WriteLineAsync(message);
        }
    }
}
