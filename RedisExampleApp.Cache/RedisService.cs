using StackExchange.Redis;

namespace RedisExampleApp.Cache;

public class RedisService(string url)
{
    private readonly ConnectionMultiplexer _connectionMultiplexer = ConnectionMultiplexer.Connect(url);

    public IDatabase GetDb(int dbIndex)
    {
        return _connectionMultiplexer.GetDatabase(dbIndex);
    }
}
