using CalorieTracker.Client.DTOs.ProductDTOs;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.UOW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CalorieTracker.Client.Services;

public class ProductService
{
    private readonly UnitOfWork _unitOfWork;

    public ProductService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task CreateProduct(CreateProductDTO createProductDTO)
    {
        Product product = new Product
        {
            Id = createProductDTO.Id,
            UserId = createProductDTO.UserId,
            ProductName = createProductDTO.ProductName,
            CaloriesPerHundredGram = createProductDTO.CaloriesPerHundredGram,
            CarbsPerHundredGram = createProductDTO.CarbsPerHundredGram,
            FatPerHundredGram = createProductDTO.FatPerHundredGram,
            ProteinPerHundredGram = createProductDTO.ProteinPerHundredGram,
            VisibilityScope = createProductDTO.VisibilityScope,
            
        };

        _unitOfWork.ProductRepository.Create(product);
        await _unitOfWork.CommitAsync ();
    }

    public async Task<IEnumerable<Product>> GetProducts()
    {
        return await _unitOfWork.ProductRepository.GetAllData()
            .Include(x => x.User)
            .ToListAsync();
    }
}
