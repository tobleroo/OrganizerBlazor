namespace OrganizerBlazor.Diary.Models.DiaryDTOs
{
    public class CreateDiaryDataDTO
    {
        public string Password { get; set; }
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
