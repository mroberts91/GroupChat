using GroupChat.Application.Common.Mappings;
using GroupChat.Domain.Entities;

namespace GroupChat.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
