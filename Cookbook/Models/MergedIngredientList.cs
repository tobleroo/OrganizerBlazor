namespace OrganizerBlazor.Cookbook.Models
{
    public class MergedIngredientList
    {
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<AdditionalFoodCurrentItem> ExtraItems { get; set; } = new List<AdditionalFoodCurrentItem>();
    }
}
