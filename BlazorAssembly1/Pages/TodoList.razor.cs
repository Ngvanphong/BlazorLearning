using BlazorAssembly1.Services;
using Microsoft.AspNetCore.Components;
using BlazorAssembly1.Model;

namespace BlazorAssembly1.Pages
{
   
    public partial class TodoList
    {
        public string Name = "Tedu";
        [Inject] private ITodoListApiClient ToDoListApiClient { set; get; }
        private IList<Model.TodoList> Todos;
        protected override async Task OnInitializedAsync()
        {

            Todos = await ToDoListApiClient.GetAll();
        }

    }
}
