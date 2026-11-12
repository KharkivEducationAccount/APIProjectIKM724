using Microsoft.AspNetCore.Mvc;
using MyProject.Application;
using MyProject.Domain;

namespace MyProject.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        productService = _productService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        Product product = await _productService.GetProductById(id);

        if(product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }
}