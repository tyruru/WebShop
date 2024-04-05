using DataAccess.MockDb;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models.Product;
using WebShop.Models.Review;

namespace WebShop.Controllers.Products;

public class GetProductsController : Controller
{
    // GET
    public IActionResult ProductsList()
    {
        IEnumerable<ProductViewModel> model =
            MockDb.Products.Select(p =>
                new ProductViewModel(p.Key, p.Value.Name, p.Value.Price, p.Value.Description,
                    p.Value.Reviews.ConvertAll(r => new ReviewViewModel(r.Id, r.Grade, r.Text, r.UserId, r.UserName))));
        return View("Products/ProductList", model);
    }
}