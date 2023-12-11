namespace OrganizerBlazor.Todo.Models
{
    public class TodoDocument
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string Owner { get; set; }

        public List<TodoCategory> TodoCategories { get; set; } = new List<TodoCategory>();

        public List<string> ActiveTodos { get; set; } = new List<string>();
    }
}
