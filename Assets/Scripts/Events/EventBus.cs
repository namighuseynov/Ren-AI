using System;
using System.Collections.Generic;

//Singleton pattern

namespace RenAI.Events
{
    public sealed class EventBus : IEventPublisher
    {
        private static EventBus _instance;
        public static EventBus Instance => _instance ??= new EventBus();

        private Dictionary<Type, List<Delegate>> _listeners = new();
        private EventBus() { }
        public void Publish<T>(T evt)
        {
            if (!_listeners.TryGetValue(typeof(T), out var handlers))
                return;
            var handlersCopy = new List<Delegate>(handlers);
            foreach (var handler in handlersCopy)
            {
                if (handler is Action<T> action)
                    action.Invoke(evt);
            }
        }

        public void Subscribe<T>(Action<T> action)
        {
            var type = typeof(T);

            if (!_listeners.TryGetValue(type, out var list))
            {
                list = new List<Delegate>();
                _listeners[type] = list;
            }

            list.Add(action);
        }

        public void Unsubscribe<T>(Action<T> action)
        {
            var type = typeof(T);

            if (!_listeners.TryGetValue(type, out var list))
                return;

            list.Remove(action);
        }
    }
}