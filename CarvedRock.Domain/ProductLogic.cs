using CarvedRock.Data;
using CarvedRock.Data.Entities;
using CarvedRock.Domain.Models;
using Microsoft.Extensions.Logging;
namespace CarvedRock.Domain;

public class ProductLogic : IProductLogic
{
    private readonly ILogger<ProductLogic> _logger;
    private readonly ICarvedRockRepository _repository;

    public ProductLogic(ILogger<ProductLogic> logger,ICarvedRockRepository repository)
    {
        _repository = repository;
        this._logger = logger;
    }
    public async Task<IEnumerable<Product>> GetProductsForCategory(string category)
    {
        _logger.LogInformation("Getting products from Get API for {x}",category);
        return await _repository.GetProductsAsync(category);
    }
}