using DataAccess.Entities.Users;

namespace DataAccess.MockDb;

public static partial class MockDb
{
    public static Dictionary<int, UserEntity> Users = new Dictionary<int, UserEntity>()
    {
        {1, new UserEntity(1, "User1", Guid.NewGuid().ToString(), "email1@gmail.com") },
        {2, new UserEntity(2, "User2", Guid.NewGuid().ToString(), "email2@gmail.com") },
        {3, new UserEntity(3, "User3", Guid.NewGuid().ToString(), "email3@gmail.com") },
        {4, new UserEntity(4, "User4", Guid.NewGuid().ToString(), "email4@gmail.com") },
        {5, new UserEntity(5, "User5", Guid.NewGuid().ToString(), "email5@gmail.com") }
    };
}