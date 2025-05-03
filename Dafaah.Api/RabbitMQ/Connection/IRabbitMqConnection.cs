using RabbitMQ.Client;

namespace Dafaah.Api.RabbitMQ.Connection
{
    public interface IRabbitMqConnection
    {
        IConnection Connection { get; }
    }
}
