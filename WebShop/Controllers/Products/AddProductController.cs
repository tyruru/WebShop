using DataAccess.Entities;
using DataAccess.MockDb;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models.Product;

namespace WebShop.Controllers.Products;

public class AddProductController : Controller
{
    [HttpGet]
    public IActionResult CreateProduct()
    {
        return View("Products/CreateProduct");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateProduct(CreateProductViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("Products/CreateProduct");
        }

        int newId = MockDb.Products.Max(p => p.Key) + 1;
        MockDb.Products.Add(newId, new ProductEntity(newId, model.Name, model.Description, model.Price));

        return RedirectToAction("ProductsList", "GetProducts");
    }
}