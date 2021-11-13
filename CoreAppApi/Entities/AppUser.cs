using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CoreAppApi.Entities
{
    public class AppUser:IdentityUser<Guid>
    {
        [MaxLength(250)]
        public string FirstName { set; get; }
        [MaxLength(250)]
        public string LastName { set; get; }   
    }
}
