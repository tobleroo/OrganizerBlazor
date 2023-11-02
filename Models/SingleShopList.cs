namespace OrganizerBlazor.Models
{
    public class SingleShopList
    {
        public string ListName { get; set; } = "not set";
        public List<SingleShopListRecipe> SingleShopListRecipes { get; set; } = new List<SingleShopListRecipe>();

        public List<string> AdditionalItems { get; set; } = new List<string>();

    }
}
