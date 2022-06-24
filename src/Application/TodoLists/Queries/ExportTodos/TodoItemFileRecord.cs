using cleanddd.Application.Common.Mappings;
using cleanddd.Domain.Entities;

namespace cleanddd.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
