using DataAccess.MockDb;
using DataAccess.Repositories.UserRepository;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models.Users;


namespace WebShop.Controllers.Users;

public class GetUsersController : Controller
{
    private readonly IUsersRepository _usersRepository;

    public GetUsersController()
    {
        
    }
    public GetUsersController(IUsersRepository userRepository)
    {
        _usersRepository = userRepository;
    }
    
    public ViewResult UserList()
    {
        IEnumerable<UserViewModel> model =
            MockDb.Users.Select(p => new UserViewModel(p.Key, p.Value.Name, p.Value.Email));

        return View("Users/UsersList", model);
    }
}