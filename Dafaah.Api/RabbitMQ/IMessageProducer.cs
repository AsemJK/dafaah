namespace Dafaah.Api.RabbitMQ
{
    public interface IMessageProducer
    {
        Task SendMessage<T>(T message);
    }
}
