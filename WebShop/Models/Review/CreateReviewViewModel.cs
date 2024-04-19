using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using WebShop.Resources;

namespace WebShop.Models.Review;

public class CreateReviewViewModel
{
    [Required(ErrorMessageResourceName = "GradeRequired", ErrorMessageResourceType = typeof(AddReviewResources))]
    [Display(Name = "Grade", ResourceType = typeof(AddReviewResources))]
    public float Grade { get; init; }
    
    [Display(Name = "Text", ResourceType = typeof(AddReviewResources))]
    public string Text { get; init; }
    
    [Required]
    [Display(Name = "UserId", ResourceType = typeof(AddReviewResources))]
    public int UserId { get; init; }
    
    [Required]
    [Display(Name = "UserName", ResourceType = typeof(AddReviewResources))]
    public string UserName { get; init; }

    
}