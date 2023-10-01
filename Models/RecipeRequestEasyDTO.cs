namespace OrganizerBlazor.Models
{
    public class RecipeRequestEasyDTO
    {
        public int Portions { get; set; } = 1;
        public string Difficulty = "any";
        public string Category = "any";
        public int MaxCookTime { get; set; } = 120;

    }
}
