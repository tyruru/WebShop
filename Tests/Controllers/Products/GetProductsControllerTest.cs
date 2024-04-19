using Microsoft.AspNetCore.Mvc;
using WebShop.Controllers.Products;
using WebShop.Models.Product;
using Xunit;

namespace Tests.Controllers;

public sealed class GetProductsControllerTest
{
    [Fact]
    public void ProductController_NoError()
    {
        GetProductsController controller = new GetProductsController();

        ViewResult result = controller.ProductsList();
        
        Assert.NotNull(result);
        Assert.NotEmpty((IEnumerable<ProductViewModel>)result.Model);
    }
}