using System;

namespace Patterns.Behavioural.TemplateMethod
{
    public abstract class ProcessingException : Exception
    {
        protected ProcessingException(string message)
            : base(message)
        { }
    }
}
