using DataAccess.Entities.Users;
using DataAccess.MockDb;
using DataAccess.Repositories.UserRepository;
using Microsoft.AspNetCore.Mvc;
using WebShop.Controllers.Users;
using WebShop.Models.Users;

namespace Tests.Controllers;
using Xunit;
using Moq;

public sealed class GetUsersControllerTests
{
    [Fact]
    public void UsersController_NoError()
    {
        // Arrange
        Mock<IUsersRepository> userRepositoryMock = new Mock<IUsersRepository>();
        userRepositoryMock
            .Setup(r => r.GetUsers())
            .Returns(new List<UserEntity>()
            {
                new UserEntity(0, "", "", "")
            });
        GetUsersController controller = new GetUsersController(userRepositoryMock.Object);

        // Act
        ViewResult result = controller.UserList();

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty((IEnumerable<UserViewModel>)result.Model);
    }

}