using RabbitMQ.Client;

namespace Dafaah.Api.RabbitMQ.Connection
{
    public class RabbitMqConnection : IRabbitMqConnection, IDisposable
    {
        private IConnection _connection;
        public IConnection Connection => _connection;

        public RabbitMqConnection()
        {
            InitializeConnectionAsync().Wait();
        }

        private async Task InitializeConnectionAsync()
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost"
            };
            _connection = await factory.CreateConnectionAsync();
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}
