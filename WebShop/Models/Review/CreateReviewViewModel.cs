using System.ComponentModel.DataAnnotations;

namespace WebShop.Models.Review;

public class CreateReviewViewModel
{
    [Required]
    public float Grade { get; init; }
    
    public string Text { get; init; }
    
    [Required]
    public int UserId { get; init; }
    
    [Required]
    public string UserName { get; init; }

    
}