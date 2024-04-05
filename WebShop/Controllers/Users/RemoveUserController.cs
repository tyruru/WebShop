using DataAccess.MockDb;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers.Users;

public class RemoveUserController : Controller
{
    // GET
    public IActionResult Delete([FromRoute] int id)
    {
        MockDb.Users.Remove(id);
        return RedirectToAction("UserList", "GetUsers");
    }
}