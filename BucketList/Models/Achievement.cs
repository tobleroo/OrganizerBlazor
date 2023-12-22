using static OrganizerBlazor.BucketList.Pages.BucketListOverview;

namespace OrganizerBlazor.BucketList.Models
{
    public class Achievement
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? CompletedOn { get; set; } = null;
        public List<Requirement> Requirements { get; set; } = new List<Requirement>();
        public bool ShowDetails { get; set; } = false;
        //public List<AchievementPicture> Pictures { get; set; } = new List<AchievementPicture>();

        public int GetProgressInPercentage()
        {
            if (Requirements.Count == 0)
            {
                return 0; // No requirements, progress is 0%
            }

            // Calculate percentage based on completed requirements
            int completedReqs = Requirements.Count(req => req.IsCompleted);
            int progress = (completedReqs * 100) / Requirements.Count;

            if (progress == 100)
            {
                IsCompleted = true;
                if (CompletedOn == null)
                {
                    CompletedOn = DateTime.Today;
                }
            }

            return progress;
        }

        // Limit the number of pictures to 2
        //public void AddPicture(AchievementPicture picture)
        //{
        //    if (Pictures.Count < 2)
        //    {
        //        Pictures.Add(picture);
        //    }
        //    else
        //    {
        //        // Handle the case when trying to add more than 2 pictures
        //        // You may want to throw an exception or handle it in some way
        //    }
        //}
    }
}
