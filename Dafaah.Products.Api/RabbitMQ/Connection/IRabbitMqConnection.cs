
using RabbitMQ.Client;

namespace Dafaah.Products.Api.RabbitMQ.Connection
{
    public interface IRabbitMqConnection
    {
        IConnection Connection { get; }
    }
}
