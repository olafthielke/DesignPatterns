using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Patterns.Behavioural.TemplateMethod
{
    public abstract class CustomerFileMiner
    {
        protected const string BaseDirectory = @"C:\Users\olaft\source\repos\DesignPatterns\Patterns\Behavioural\TemplateMethod";

        protected abstract string InDirectory { get; }
        protected abstract string OutDirectory { get; }

        private string IncomingDirectory => $@"{BaseDirectory}{InDirectory}";
        protected string DoneDirectory => $@"{BaseDirectory}{OutDirectory}";


        public IList<Customer> MineCustomers()
        {
            var files = CheckForFiles();
            if (!files.Any())
                return new List<Customer>();
            return ProcessFiles(files);
        }

        private IList<string> CheckForFiles()
        {
            return new List<string>(Directory.GetFiles(IncomingDirectory));
        }

        protected IList<Customer> ProcessFiles(IList<string> filePaths)
        {
            var customers = new List<Customer>();
            foreach (var filePath in filePaths)
                customers.AddRange(TryProcessFile(filePath));
            return customers;
        }

        protected IList<Customer> TryProcessFile(string filePath)
        {
            try
            {
                return ProcessFile(filePath);
            }
            catch (ProcessingException)
            {
                // TODO: Log the error.
                return new List<Customer>();
            }
        }

        // Template Method
        private IList<Customer> ProcessFile(string filePath)
        {
            ValidateFile(filePath);
            filePath = PreprocessFile(filePath);
            var customers = ReadCustomersFromFile(filePath);
            PostprocessFile(filePath);
            return customers;
        }

        // Template steps
        protected virtual void ValidateFile(string filePath)
        {
            // By default do nothing.
        }

        protected virtual string PreprocessFile(string filePath)
        {
            // By default do nothing.
            return filePath;
        }

        protected abstract IList<Customer> ReadCustomersFromFile(string filePath);


        protected virtual void PostprocessFile(string filePath)
        {
            MoveFileToDoneDirectory( filePath);
        }


        protected void ValidateFileExtension(string filePath, string fileExtension)
        {
            var extension = Path.GetExtension(filePath);
            if (extension != fileExtension)
                throw new InvalidFileType(filePath, fileExtension);
        }

        protected void MoveFileToDoneDirectory(string filePath)
        {
            var file = new FileInfo(filePath);
            File.Move(filePath, $"{DoneDirectory}\\{file.Name}");
        }
    }
}
