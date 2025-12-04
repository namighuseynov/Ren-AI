namespace RenAI.Events
{
    public interface IEventPublisher
    {
        void Publish<T>(T evt);
        void Subscribe<T>(System.Action<T> action);
        void Unsubscribe<T>(System.Action<T> action);
    }
}