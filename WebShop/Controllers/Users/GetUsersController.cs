using DataAccess.MockDb;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models.Users;


namespace WebShop.Controllers.Users;

public class GetUsersController : Controller
{
    // GET
    public IActionResult UserList()
    {
        IEnumerable<UserViewModel> model =
            MockDb.Users.Select(p => new UserViewModel(p.Key, p.Value.Name, p.Value.Email));

        return View("Users/UsersList", model);
    }
}