using CoreAppApi.Data;
using CoreAppApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreAppApi.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoListDbContext _context;
        public TodoRepository(TodoListDbContext context)
        {
            _context = context;
        }
        public async Task<Todo> Create(Todo todo)
        {
           await _context.Todos.AddAsync(todo);
           await _context.SaveChangesAsync();
           return todo;
        }

        public async Task<Todo> Delete(Todo todo)
        {
            _context.Remove(todo);
            await _context.SaveChangesAsync();
            return todo;
        }

        public async Task<IEnumerable<Todo>> GetAll()
        {
            return await _context.Todos.ToListAsync();
        }

        public async Task<Todo> GetById(Guid id)
        {
            return await _context.Todos.FindAsync(id)??new Todo();
        }

        public async Task<Todo> Update(Todo todo)
        {
            _context.Todos.Update(todo);
            await _context.SaveChangesAsync();
            return todo;
        }
    }
}
