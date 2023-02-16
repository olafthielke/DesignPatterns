using StackExchange.Redis;

namespace Patterns.Structural.Facade.Interfaces
{
    public interface IRedisConnector
    {
        ConnectionMultiplexer Connection { get; }
    }
}
