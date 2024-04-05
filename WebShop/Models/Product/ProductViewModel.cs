using DataAccess.Entities;
using Microsoft.AspNetCore.DataProtection;
using WebShop.Models.Review;

namespace WebShop.Models.Product;

public class ProductViewModel
{
    public int Id { get; }
    public string Name { get; }
    public float Price { get; }
    public string Description { get; }
    public List<ReviewViewModel> Reviews { get;}

    public ProductViewModel(int id, string name, float price, string description, List<ReviewViewModel> reviews)
    {
        Id = id;
        Name = name;
        Price = price;
        Description = description;
        Reviews = reviews;
    }
}