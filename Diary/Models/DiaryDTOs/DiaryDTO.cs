namespace OrganizerBlazor.Diary.Models.DiaryDTOs
{
    public class DiaryDTO
    {
        public required string OwnerName { get; set; }

        public List<DiaryPost> Posts { get; set; } = new List<DiaryPost>();

        public string OwnerHomeCountry { get; set; } = string.Empty;
        public string OwnerHomeTown { get; set; } = string.Empty;
    }
}
