namespace DataAccess.Entities;

public interface IUser
{
    public int Id { get; }
    public string Name { get; }
    public string Password { get; }

}