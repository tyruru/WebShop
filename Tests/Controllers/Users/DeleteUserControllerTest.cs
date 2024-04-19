using WebShop.Controllers.Users;
using WebShop.Models.Users;
using Xunit;

namespace Tests.Controllers;

public sealed class DeleteUserControllerTest
{
    [Fact]
    public void UserController_Delete()
    {
        int startSize, endSize;
        var users = GetUsersList();

        startSize = users.Count;

        RemoveUserController removeController = new();

        removeController.Delete(users[0].Id);

        users = GetUsersList();

        endSize = users.Count;
        
        Assert.Equal(startSize-1, endSize);
    }
    
    private List<UserViewModel> GetUsersList()
    {
        GetUsersController getController = new GetUsersController();
        
        var usersView = getController.UserList();
        var usersModel = usersView.Model;
        var users = (IEnumerable<UserViewModel>)usersModel;
        var usersList = users.ToList();

        return usersList;
    }
}
