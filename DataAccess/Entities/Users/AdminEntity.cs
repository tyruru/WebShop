namespace DataAccess.Entities.Users;

public sealed class AdminEntity : IUser
{
    public int Id { get; }
    public string Name { get; }
    public string Password { get; }

    public AdminEntity(int id, string name, string password)
    {
        Id = id;
        Name = name;
        Password = password;
    }
}