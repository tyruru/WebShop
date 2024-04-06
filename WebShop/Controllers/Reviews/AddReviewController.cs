using DataAccess.Entities;
using DataAccess.MockDb;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models.Review;

namespace WebShop.Controllers.Reviews;

public class AddReviewController : Controller
{
    [HttpGet]
    public IActionResult CreateReview()
    {
        return View("Reviews/CreateReview");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateReview(CreateReviewViewModel model, int id)
    {
        // int id = 0;
        if (!ModelState.IsValid)
        {
            return View("Reviews/CreateReview");
        }
        
        int newId = MockDb.Products.Values
            .SelectMany(product => product.Reviews)
            .Select(review => review.Id)
            .DefaultIfEmpty()
            .Max();

        ReviewEntity review = new ReviewEntity(newId, model.Grade, model.Text, model.UserId, model.UserName);
        
        MockDb.Products[id].Reviews.Add(review);
        return RedirectToAction("ProductsList", "GetProducts");
    }
}