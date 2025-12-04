using System;

namespace RenAI.Events
{
    public abstract class Event
    {
        public DateTime At { get; } = DateTime.Now;
    }
}