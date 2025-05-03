using RabbitMQ.Client;

namespace Dafaah.Api.RabbitMQ
{
    public class RabbitMqConnection : IRabbitMqConnection, IDisposable
    {
        private IConnection _connection;
        public IConnection Connection => _connection;

        public RabbitMqConnection()
        {
            InitializeConnectionAsync().Wait(); // Use .Wait() to handle async initialization in a synchronous constructor  
        }

        private async Task InitializeConnectionAsync()
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost"
            };
            _connection = await factory.CreateConnectionAsync(); // Use the async method to create the connection  
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}
