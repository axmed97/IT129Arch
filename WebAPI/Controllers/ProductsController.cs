using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        _productService.Create(product);
        return Ok();
    }
}
