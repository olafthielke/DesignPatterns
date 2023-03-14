﻿using System;

namespace Patterns.Behavioural.NullObject
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
