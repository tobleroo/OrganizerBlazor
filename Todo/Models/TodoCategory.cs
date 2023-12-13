namespace OrganizerBlazor.Todo.Models
{
    public class TodoCategory
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string CategoryTitle { get; set; }
        public List<TodoActivity> Activities { get; set; } = new List<TodoActivity>();
    }
}
