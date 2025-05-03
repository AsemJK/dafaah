using RabbitMQ.Client;

namespace Dafaah.Api.RabbitMQ
{
    public interface IRabbitMqConnection
    {
        IConnection Connection { get; }
    }
}
