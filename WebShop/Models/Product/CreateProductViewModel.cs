using System.ComponentModel.DataAnnotations;

namespace WebShop.Models.Product;

public class CreateProductViewModel
{
    [Required]
    public string Name { get; init; }
    
    [Required]
    public float Price { get; init; }
    
    [Required]
    public string Description { get; init; }
}