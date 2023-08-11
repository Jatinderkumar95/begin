using CarvedRock.Domain;
using CarvedRock.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarvedRock.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductLogic _productLogic;
    private const int GetEvent = 1000;
    public ProductController(ILogger<ProductController> logger,IProductLogic productLogic)
    {
        _logger = logger;
        _productLogic = productLogic;
    }

    [HttpGet]
    public async Task<IEnumerable<ProductModel>> Get(string category = "all")
    {
        _logger.LogInformation("Getting products from Get API for {x}",category);
        _logger.Log(LogLevel.Information,GetEvent,"Getting products from Get API for {x}",category);
        return await _productLogic.GetProductsForCategory(category);
    }
}