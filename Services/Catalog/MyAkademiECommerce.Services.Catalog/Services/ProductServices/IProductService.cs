using MyAkademiECommerce.Services.Catalog.Dtos.ProductDtos;

namespace MyAkademiECommerce.Services.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<ResultProductDto> GetProductAsync(string id);
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
    }
}