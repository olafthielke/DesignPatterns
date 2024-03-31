namespace Patterns.Creational.Monostate
{
    public class SimpleMonostate
    {
        private static string _data;

        public string Data
        {
            get => _data;
            set => _data = value;
        }

        // Instance Behaviour (public methods and properties)
        // i.e. WHAT this class is used for.
    }
}
