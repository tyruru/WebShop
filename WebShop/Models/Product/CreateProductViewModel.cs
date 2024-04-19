using System.ComponentModel.DataAnnotations;
using WebShop.Resources;

namespace WebShop.Models.Product;

public class CreateProductViewModel
{
    [Required(ErrorMessageResourceName = "NameRequired", ErrorMessageResourceType = typeof(AddProductResources))]
    [Display(Name = "Name", ResourceType = typeof(AddProductResources))]
    public string Name { get; init; }
    
    [Required(ErrorMessageResourceName = "PriceRequired", ErrorMessageResourceType = typeof(AddProductResources))]
    [Display(Name = "Price" , ResourceType = typeof(AddProductResources))]

    public float Price { get; init; }
    
    [Display(Name = "Description", ResourceType = typeof(AddProductResources))]
    public string Description { get; init; }
}