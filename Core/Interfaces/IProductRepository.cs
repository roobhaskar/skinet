using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<product> GetProductByIdAsync(int id);

        Task<IReadOnlyList<product>> GetProductsAsync();

        Task<IReadOnlyList<ProductBrand>> GetProductBrandAsync();

        Task<IReadOnlyList<ProductType>> GetProductTypeAsync();
    }
}