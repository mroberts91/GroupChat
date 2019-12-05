using GroupChat.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace GroupChat.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
