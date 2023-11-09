namespace OrganizerBlazor.Cookbook.Models.CookBookDTO
{
    public class RecipeOverviewData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int TimeToCook {  get; set; }
        private int _recipeType;
        //since enums are saved in cosmos as int values i need to convert it into string value of the index value
        public string RecipeType
        {
            get => ((RecipeTypes)_recipeType).ToString();
            set
            {
                if (Enum.TryParse<RecipeTypes>(value, out var recipeType))
                {
                    _recipeType = (int)recipeType;
                }
            }
        }
        public string Difficulty { get; set; }
    }
}
