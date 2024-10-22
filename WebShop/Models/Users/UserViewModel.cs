namespace WebShop.Models.Users;

public class UserViewModel
{
    public int Id { get; }
    public string UserName { get; }
    public string Email { get; }
    
    public UserViewModel(int id, string userName, string email)
    {
        Id = id;
        UserName = userName;
        Email = email;
    }
}