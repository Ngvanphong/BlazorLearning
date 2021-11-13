using Microsoft.AspNetCore.Identity;

namespace BlazorAssembly1.Model
{
    public class AppUser:IdentityUser<Guid>
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
    }
}
