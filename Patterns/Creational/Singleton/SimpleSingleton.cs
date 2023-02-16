using System;

namespace Patterns.Creational.Singleton
{
    public class SimpleSingleton
    {
        // Static field (or property) to hold single instance.
        private static SimpleSingleton _instance;

        // Private constructor to avoid direct instantiation.
        private SimpleSingleton()
        { }

        // Static method to retrieve single instance. 
        public static SimpleSingleton GetInstance()
        {
            if (_instance == null)
                _instance = new SimpleSingleton();
            return _instance;
        }


        // Instance Behaviour (public methods and properties)
        // i.e. WHAT this class is used for.

        public string Data { get; set; }
    }
}
