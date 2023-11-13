namespace OrganizerBlazor.Cookbook.Models
{

    public class UserCookBook
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string OwnerUsername { get; set; }
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();

        public List<SingleShopList> GroceriesShoppingLists { get; set; } = new List<SingleShopList>();
        public List<AdditionalFoodItem> PreviouslyAddedAdditonalItems { get; set; } = new();
    }
}