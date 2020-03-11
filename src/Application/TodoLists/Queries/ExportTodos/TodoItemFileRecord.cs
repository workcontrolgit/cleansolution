using cleansolution.Application.Common.Mappings;
using cleansolution.Domain.Entities;

namespace cleansolution.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
