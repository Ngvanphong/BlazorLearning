using BlazorAssembly1.Model;

namespace BlazorAssembly1.Services
{
    public interface ITodoListApiClient
    {
        public Task<List<TodoList>> GetAll();
    }
}
