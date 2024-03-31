namespace Patterns.Creational.Singleton
{
    public class SimpleSingleton
    {
        private static SimpleSingleton _instance;

        private SimpleSingleton()
        { }

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
