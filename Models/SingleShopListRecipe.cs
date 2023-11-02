namespace OrganizerBlazor.Models
{
    public class SingleShopListRecipe
    {
        public string RecipeName { get; set; } = "not set";
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
