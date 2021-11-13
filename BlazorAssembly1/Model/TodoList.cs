namespace BlazorAssembly1.Model
{
    public class TodoList
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? AssigneeId { get; set; }
        public AppUser Assignee { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
