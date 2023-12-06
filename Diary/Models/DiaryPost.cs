namespace OrganizerBlazor.Diary.Models
{
    public class DiaryPost
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public string PublishedInCountry { get; set; } = string.Empty;

        public string PublishedInTown { get; set; } = string.Empty;

        //start on 0 to know if user hasnt entered a value for this
        private int _happyRating = 0;
        public int HappyRating
        {
            get => _happyRating;
            set
            {
                if (value >= 1 && value <= 5)
                {
                    _happyRating = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(HappyRating), "HappyRating must be between 1 and 5.");
                }
            }
        }
    }
}
