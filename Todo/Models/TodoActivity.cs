using System.Text.Json.Serialization;

namespace OrganizerBlazor.Todo.Models
{
    public class TodoActivity
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string Title { get; set; }

        public int FrequencyAmount { get; set; } = 0;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FrequencyTypes FrequencyType { get; set; }

        public List<string> DatesWhenCompleted { get; set; } = new List<string>();

        public int TimeToPerformMinutes { get; set; } = 0;
    }
}
