using cleanddd.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace cleanddd.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
