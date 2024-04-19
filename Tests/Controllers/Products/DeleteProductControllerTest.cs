using WebShop.Controllers.Products;
using WebShop.Controllers.Users;
using WebShop.Models.Product;
using Xunit;

namespace Tests.Controllers;

public sealed class DeleteProductControllerTest
{
    [Fact]
    public void ProductController_Delete()
    {
        int startSize, endSize;
        
        var productList = GetProductList();
        
        startSize = productList.Count;

        int id = productList[0].Id;
         
        RemoveProductController removeProductController = new();
        
        removeProductController.Delete(id);

        productList = GetProductList();

        endSize = productList.Count;
         
        Assert.Equal(startSize-1, endSize);
    }

    private List<ProductViewModel> GetProductList()
    {
        GetProductsController getController = new GetProductsController();
        
        var productsView = getController.ProductsList();
        var productsModel = productsView.Model;
        var products = (IEnumerable<ProductViewModel>)productsModel;
        var productList = products.ToList();

        return productList;
    }
}