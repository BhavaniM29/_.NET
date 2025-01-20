// Controllers/ProductController.cs
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private static List<Product> _products = new List<Product>();

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        return Ok(_products);
    }

    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound();
        return Ok(product);
    }

    [HttpPost]
    public ActionResult<Product> Create(Product product)
    {
        // No need to check for null Name or Price as the required keyword ensures they are provided
    var newProduct = new Product
    {
        Id = product.Id,
        Name = product.Name,
        Price = product.Price,
        Description = product.Description // This is optional
    };
    
    _products.Add(newProduct);
    return CreatedAtAction(nameof(GetById), new { id = newProduct.Id }, newProduct);
    }
}
