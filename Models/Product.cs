// Models/Product.cs
// Models/Product.cs
public class Product
{
    public required int Id { get; init; }
    
    public required string Name { get; init; }
    
    public required decimal Price { get; init; }
    
    public string? Description { get; init; } // Making Description optional since it might not always be needed
}
