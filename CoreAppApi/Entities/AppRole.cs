using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CoreAppApi.Entities
{
    public class AppRole:IdentityRole<Guid>
    {
        [MaxLength(250)]
        [Required]
        public string Description { set; get; }
    }
}
