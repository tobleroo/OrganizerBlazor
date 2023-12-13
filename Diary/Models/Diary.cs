namespace OrganizerBlazor.Diary.Models
{
    public class Diary
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string OwnerName { get; set; }

        public List<DiaryPost> Posts { get; set; } = new List<DiaryPost>();

        public string OwnerHomeCountry { get; set; } = string.Empty;
        public string OwnerHomeTown { get; set;} = string.Empty;

    }
}
