using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavioural.NullObject
{
    public class ClassThatDoesSomeStuff
    {
        private ILogger Logger { get; set; }

        public ClassThatDoesSomeStuff(ILogger logger) 
        {
            Logger = logger;
        }


        public int DoSomeStuff(int a, int b)
        {
            var c = a + b;

            Logger.Log($"{a} + {b} = {c}");

            return c;
        }
    }
}
