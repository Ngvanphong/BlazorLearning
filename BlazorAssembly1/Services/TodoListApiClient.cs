using BlazorAssembly1.Model;
using System.Net.Http.Json;

namespace BlazorAssembly1.Services
{
    public class TodoListApiClient:ITodoListApiClient
    {
        private readonly HttpClient _httpClient;
        public TodoListApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TodoList>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<TodoList>>("/api/todo");
            return result;
        }
    }
}
