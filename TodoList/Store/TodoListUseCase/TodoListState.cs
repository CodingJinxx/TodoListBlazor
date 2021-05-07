using System.Collections.Generic;

namespace TodoList.Store.TodoListUseCase
{
    public record TodoListState
    {
        public List<TodoEntry> TodoEntries { get; init; }
    }
}