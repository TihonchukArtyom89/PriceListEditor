using Microsoft.AspNetCore.Mvc;
using PriceListEditor.WebApplication.Models;

namespace PriceListEditor.WebApplication.Controllers;

public class ProductController : Controller
{
    private IProductRepository productRepository;
    public ProductController(IProductRepository _productRepository)
    {
        productRepository = _productRepository;
    }
    public IActionResult ProductList()
    {
        return View("ProductList", productRepository.Products);
    }
}
