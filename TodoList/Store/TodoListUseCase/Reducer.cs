using Fluxor;

namespace TodoList.Store.TodoListUseCase
{
    public static class Reducer
    {
        [ReducerMethod]
        public static TodoListState AddTodoAction(TodoListState state, AddTodoAction action)
        {
            state.TodoEntries.Add(new TodoEntry(false, action.input));
            return state;
        }
    }
}