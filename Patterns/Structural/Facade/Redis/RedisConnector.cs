using System;
using Patterns.Structural.Facade.Interfaces;
using StackExchange.Redis;

namespace Patterns.Structural.Facade.Redis
{
    public class RedisConnector : IRedisConnector
    {
        private static Lazy<ConnectionMultiplexer> _connection;

        public RedisConnector(string host)
        {
            _connection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(host));
        }

        public RedisConnector(IRedisConfiguration config)
            : this(config.Host)
        { }

        public ConnectionMultiplexer Connection => _connection.Value;
    }
}
