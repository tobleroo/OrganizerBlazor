using OrganizerBlazor.Cookbook.Models;

namespace OrganizerBlazor.Cookbook.Models.CookBookDTO
{
    public class ShoppingListPageDTO
    {
        public SingleShopList? SingleShopList { get; set; }
        public List<AdditionalFoodCurrentItem>? AdditionalItems { get; set; }

        public List<string>? RecommendedAdditionalItems { get; set; } = new();
    }
}
