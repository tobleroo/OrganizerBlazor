namespace OrganizerBlazor.Models{
    public class ShoppingList
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public required string ListName { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public List<string> AdditionalItems { get; set; } = new();
    }
}