using CarvedRock.Data.Entities;
using CarvedRock.Domain.Models;

namespace CarvedRock.Domain;

public interface IProductLogic 
{
    Task<IEnumerable<Product>> GetProductsForCategory(string category);
}