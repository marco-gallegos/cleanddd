using cleanddd.Domain.Common;
using cleanddd.Domain.Entities;

namespace cleanddd.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
