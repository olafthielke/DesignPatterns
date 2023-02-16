namespace Patterns.Creational.Monostate
{
    public class SimpleMonostate
    {
        // Static field (or property) to hold single instance.
        private static string _data;

        public string Data
        {
            get => _data;
            set => _data = value;
        }
    }
}
