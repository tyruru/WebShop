namespace DataAccess.Entities.Users;

public sealed class OperatorEntity : IUser
{
    public int Id { get; }
    public string Name { get; }
    public string Password { get; }

    public OperatorEntity(int id, string name, string password)
    {
        Id = id;
        Name = name;
        Password = password;
    }
}