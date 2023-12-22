namespace OrganizerBlazor.BucketList.Models
{
    public class BucketlistDocument
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string Owner { get; set; }
        public List<Achievement> Achievements { get; set; } = new();
    }
}
