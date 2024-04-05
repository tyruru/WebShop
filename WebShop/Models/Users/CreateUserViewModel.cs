using System.ComponentModel.DataAnnotations;

namespace WebShop.Models.Users;

public class CreateUserViewModel
{
    [MinLength(5)]
    [MaxLength(12)]
    [Required]
    public string UserName { get; init; }
    
    [Required]
    public string Email { get; init; }
    
    [Required]
    public string Password { get; init; }
}