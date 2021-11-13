using CoreAppApi.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CoreAppApi.Data
{
    public class TodoListDbContextSeed
    {
        private static readonly IPasswordHasher<AppUser> _passwordHasher= new PasswordHasher<AppUser>();
        public static async Task SeedData(ModelBuilder builder)
        {
            var user = new Entities.AppUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "Mr",
                LastName = "A",
                Email = "adim@gamil.com",
                PhoneNumber = "010101010",
                UserName = "adim",
            };
            user.PasswordHash = _passwordHasher.HashPassword(user, "Admin@123");
            builder.Entity<AppUser>().HasData(user);
            var toto = new Entities.Todo()
            {
                Id = Guid.NewGuid(),
                Name = "Sample 1",
                AssigneeId= user.Id,
                CreatedDate = DateTime.Now,
                Priority = Enums.Priority.High,
                Status = Enums.Status.Open,
            };
            builder.Entity<Todo>().HasData(toto);

        }
    }
}
