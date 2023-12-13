namespace OrganizerBlazor.Todo.Models.DTOs
{
    public class TodoSuggestionsDTO
    {
        public Dictionary<string, int> SuggestedActivites { get; set; } = new Dictionary<string, int>();
        public List<string> ActivitesNeverDone { get; set; } = new List<string>();
    }
}
