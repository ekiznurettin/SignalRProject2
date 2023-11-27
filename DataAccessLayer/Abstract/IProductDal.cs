using EntityLayer.Dtos.ProductDtos;
using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<ProductDto> GetProductsWithCategories();
        int GetProductCount();
        int GetProductCountByCategoryName(string categoryName);
        decimal GetProductAvgPrice();

        string GetProductNameByMaxPrice();
        string GetProductNameByMinPrice();
        decimal GetProductPriceByElektronik();
    }
}
