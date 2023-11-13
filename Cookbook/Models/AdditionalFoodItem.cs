namespace OrganizerBlazor.Cookbook.Models
{
    public class AdditionalFoodItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "not set";

        public List<string> DatesWhenShopped { get; set; } = new List<string>();
    }
}
