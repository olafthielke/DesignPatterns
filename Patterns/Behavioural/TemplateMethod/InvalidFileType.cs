using System;

namespace Patterns.Behavioural.TemplateMethod
{
    public class InvalidFileType : ProcessingException
    {
        public InvalidFileType(string fileName, string fileType)
            : base($"{fileName} is not of type {fileType}.")
        { }
    }
}
