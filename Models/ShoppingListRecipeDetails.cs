namespace OrganizerBlazor.Models
{
    public class ShoppingListRecipeDetails
    {
        public required string RecipeName { get; set; }
        public required List<Ingredient> Ingredients { get; set; }
    }
}
