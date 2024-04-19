using System.ComponentModel.DataAnnotations;
using WebShop.Resources;

namespace WebShop.Models.Users;

public class CreateUserViewModel
{
    [MinLength(5)]
    [MaxLength(12)]
    [Required(ErrorMessageResourceName = "UserNameRequired", ErrorMessageResourceType = typeof(SharedResources))]
    [Display(Name = "UserName", ResourceType = typeof(SharedResources))]
    public string UserName { get; init; }
    
    [Required(ErrorMessageResourceName = "EmailRequired", ErrorMessageResourceType = typeof(SharedResources))]
    [Display(Name = "Email", ResourceType = typeof(SharedResources))]
    public string Email { get; init; }
    
    [Required(ErrorMessageResourceName = "PasswordRequired", ErrorMessageResourceType = typeof(SharedResources))]
    [Display (Name = "Password", ResourceType = typeof(SharedResources))]
    public string Password { get; init; }
}