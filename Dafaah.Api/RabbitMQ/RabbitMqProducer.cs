using Dafaah.Api.RabbitMQ.Connection;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace Dafaah.Api.RabbitMQ
{
    public class RabbitMqProducer : IMessageProducer
    {
        private readonly IRabbitMqConnection _mqConnection;

        public RabbitMqProducer(IRabbitMqConnection mqConnection)
        {
            _mqConnection = mqConnection;
        }

        public async Task SendMessage<T>(T message)
        {
            using var channel = await _mqConnection.Connection.CreateChannelAsync();
            await channel.QueueDeclareAsync(queue: "hello", durable: false, exclusive: false, autoDelete: false);
            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));
            await channel.BasicPublishAsync(exchange: string.Empty, routingKey: "hello", mandatory: false, body: body);
        }
    }
}
