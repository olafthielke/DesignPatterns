using Patterns.Structural.Facade.Interfaces;

namespace Patterns.Structural.Facade.Redis
{
    public class RedisConfiguration : IRedisConfiguration
    {
        // Imagine that Host is being read from a config file.
        public string Host => "localhost";
    }
}
