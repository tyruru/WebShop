using DataAccess.Entities.Users;
using DataAccess.MockDb;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models.Users;

namespace WebShop.Controllers.Users;

public sealed class AddUserController : Controller
{
    [HttpGet]

    public IActionResult CreateUser()
    {
        return View("Users/CreateUser");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]

    public IActionResult CreateUser(CreateUserViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("Users/CreateUser");
        }

        int newId = MockDb.Users.Max(p => p.Key) + 1;
        MockDb.Users.Add(newId, new UserEntity(newId, model.UserName, model.Email, model.Password));
        return RedirectToAction("UserList", "GetUsers");
    }
}