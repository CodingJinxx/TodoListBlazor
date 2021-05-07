using Fluxor;
using Microsoft.AspNetCore.Components;
using TodoList.Store.TodoListUseCase;

namespace TodoList.Pages
{
    public partial class TodoListPage
    {
        [Inject]
        public IState<TodoListState> TodoListState { get; set; } 
        
        [Inject]
        public IDispatcher Dispatcher { get; set; }
    }
}