using DataAccess.MockDb;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers.Products;

public class RemoveProductController : Controller
{
    // GET
    public IActionResult Delete([FromRoute] int id)
    {
        MockDb.Products.Remove(id);
        return RedirectToAction("ProductsList", "GetProducts");
    }
}