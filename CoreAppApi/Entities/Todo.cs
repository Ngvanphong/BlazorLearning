using CoreAppApi.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreAppApi.Entities
{
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }    
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }    
        public Guid? AssigneeId { get; set; }

        [ForeignKey("AssigneeId")]
        public AppUser Assignee { get; set; }   

        public DateTime CreatedDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
    }
}
