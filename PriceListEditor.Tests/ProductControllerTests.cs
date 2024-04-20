using Microsoft.EntityFrameworkCore.Migrations;

namespace PriceListEditor.Tests;

public class ProductControllerTests
{
    [Fact]
    public void Can_Use_Repository()
    {
        // Arrange
        Mock<IProductRepository> mock = new ();
        mock.Setup(m => m.Products).Returns((new Product[] {
            new() { ProductID = 1, ProductName = "P1" },
            new() { ProductID = 2, ProductName = "P2" }}).AsQueryable<Product>()
            );
        ProductController controller = new (mock.Object);
        // Act
        IEnumerable<Product>? result =
        (controller.ProductList() as ViewResult)?.ViewData.Model
        as IEnumerable<Product>;
        // Assert
        Product[] prodArray = result?.ToArray()
        ?? Array.Empty<Product>();
        Assert.True(prodArray.Length == 2);
        Assert.Equal("P1", prodArray[0].ProductName);
        Assert.Equal("P2", prodArray[1].ProductName);
    }
}