using System.Collections.Generic;
using Fluxor;

namespace TodoList.Store.TodoListUseCase
{
    public class Feature : Feature<TodoListState>
    {
        public override string GetName()
        {
            return "TodoList";
        }

        protected override TodoListState GetInitialState()
        {
            return new TodoListState()
            {
                TodoEntries = new List<TodoEntry>()
            };
        }
    }
}