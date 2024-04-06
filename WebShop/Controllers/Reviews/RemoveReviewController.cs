using DataAccess.MockDb;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers.Reviews;

public class RemoveReviewController : Controller
{
    public IActionResult Delete(int modelId, int reviewId)
    {
        MockDb.Products[modelId].Reviews.RemoveAll(review => review.Id == reviewId);
        return RedirectToAction("ProductsList", "GetProducts");
    }
}