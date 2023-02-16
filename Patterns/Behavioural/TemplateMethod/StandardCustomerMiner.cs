using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace Patterns.Behavioural.TemplateMethod
{
    public class StandardCustomerMiner : CustomerFileMiner
    {
        protected override string InDirectory => @"\Incoming\Standard";
        protected override string OutDirectory => @"\Done\Standard";


        protected override void ValidateFile(string filePath)
        {
            ValidateFileExtension(filePath, ".zip");
        }

        protected override string PreprocessFile(string filePath)
        {
            UnzipIntoSameDirectory(filePath);
            MoveFileToDoneDirectory(filePath);
            return ChangeFileExtensionToCsv(filePath);
        }

        protected override IList<Customer> ReadCustomersFromFile(string filePath)
        {
            var customerLines = File.ReadLines(filePath);

            var customers = new List<Customer>();
            foreach (var customerLine in customerLines)
                customers.Add(BuildCustomer(customerLine));

            return customers;
        }

        private static void UnzipIntoSameDirectory(string filePath)
        {
            var dir = new FileInfo(filePath).DirectoryName;
            ZipFile.ExtractToDirectory(filePath, dir);
        }

        private static string ChangeFileExtensionToCsv(string filePath)
        {
            var fileParts = filePath.Split('.');
            return $"{fileParts[0]}.csv";
        }

        private static Customer BuildCustomer(string customerLine)
        {
            var parts = customerLine.Split(',');
            return new Customer(parts[0], parts[1], parts[2]);
        }
    }
}
