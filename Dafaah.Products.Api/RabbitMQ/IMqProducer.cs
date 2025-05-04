namespace Dafaah.Products.Api.RabbitMQ
{
    public interface IMqProducer
    {
        Task SendMessage<T>(T message);
    }
}
