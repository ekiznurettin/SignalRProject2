using EntityLayer.Dtos.ProductDtos;
using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<ProductDto> TGetProductsWithCategories();
        public int TGetProductCount();
        int TGetProductCountByCategoryName(string categoryName);
        decimal TGetProductAvgPrice();
        string TGetProductNameByMaxPrice();
        string TGetProductNameByMinPrice();
        decimal TGetProductPriceByElektronik();
    }
}
