namespace OrganizerBlazor.BucketList.Models
{
    public class AchievementPicture
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = "";
        public byte[]? ImageData { get; set; } = null;
    }
}
