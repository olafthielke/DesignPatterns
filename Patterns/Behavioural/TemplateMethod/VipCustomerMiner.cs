using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Patterns.Behavioural.TemplateMethod
{
    public class VipCustomerMiner : CustomerFileMiner
    {
        protected override string InDirectory => @"\Incoming\VIP";
        protected override string OutDirectory => @"\Done\VIP";


        protected override void ValidateFile(string filePath)
        {
            ValidateFileExtension(filePath, ".json");
        }

        protected override IList<Customer> ReadCustomersFromFile(string filePath)
        {
            var customerString = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<List<Customer>>(customerString);
        }

        protected override void PostprocessFile(string filePath)
        {
            MoveFileToDoneDirectory(filePath);
        }
    }
}
