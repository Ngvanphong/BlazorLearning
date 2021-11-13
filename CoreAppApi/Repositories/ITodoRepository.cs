using CoreAppApi.Entities;

namespace CoreAppApi.Repositories
{
    public interface ITodoRepository
    {
        Task<IEnumerable<Todo>> GetAll();
        Task<Todo> Create(Todo todo);
        Task<Todo> Update(Todo todo);
        Task<Todo> GetById(Guid id);
        Task<Todo> Delete(Todo todo);
    }
}
