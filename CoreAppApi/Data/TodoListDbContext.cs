using CoreAppApi.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoreAppApi.Data
{
    public class TodoListDbContext:IdentityDbContext<AppUser,AppRole,Guid>
    {
        public TodoListDbContext(DbContextOptions<TodoListDbContext> option):base(option)
        {
            
        }
        protected override async void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //await TodoListDbContextSeed.SeedData(builder);
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
