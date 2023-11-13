namespace OrganizerBlazor.Cookbook.Models
{
    public class RecipeRequestEasyDTO
    {
        public int portions { get; set; } = 1;
        public string difficulty { get; set; }
        public string category { get; set; }
        public int maxCookTime { get; set; } = 120;

    }
}
