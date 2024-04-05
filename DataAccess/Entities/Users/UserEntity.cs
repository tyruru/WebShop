namespace DataAccess.Entities.Users;

public sealed class UserEntity : IUser
{
    public int Id { get; }
    public string Name { get; }
    public string Password { get; }
    public string Email { get; }
    public List<ProductEntity> Orders { get; set; }

    public UserEntity(int id, string name, string password, string email)
    {
        Id = id;
        Name = name;
        Password = password;
        Email = email;
        Orders = new List<ProductEntity>();
    }
}