using CalorieTracker.Client.DTOs.ProductDTOs;
using CalorieTracker.Client.Entities;

namespace CalorieTracker.Client.Contracts.Services;

public interface IProductService
{
    public Task CreateProduct(CreateProductDTO createProductDTO);
    public Task<IEnumerable<Product>> GetProducts();
}