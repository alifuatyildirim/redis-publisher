using StackExchange.Redis;

const string RedisConnectionString = "localhost:6379";
ConnectionMultiplexer connection=ConnectionMultiplexer.Connect(RedisConnectionString);
const string Channel="channel_one";
var pubsub=connection.GetSubscriber();
pubsub.PublishAsync(Channel,"test alisssss",CommandFlags.FireAndForget);
Console.WriteLine("Mesaj gönderildi.");