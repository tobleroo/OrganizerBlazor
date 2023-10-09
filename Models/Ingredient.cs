public class Ingredient
{
    public Guid Guid { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "new ingredient";
    public double? Quantity { get; set; }
    public string? Unit { get; set; }
}