using cleansolution.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace cleansolution.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
