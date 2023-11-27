using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Dtos.ProductDtos;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product Entity)
        {
            _productDal.Add(Entity);
        }

        public void TDelete(Product Entity)
        {
            _productDal.Delete(Entity);
        }

        public List<Product> TGetAll()
        {
           return _productDal.GetAll();
        }

        public Product TGetById(int id)
        {
           return _productDal.GetById(id);
        }

        public decimal TGetProductAvgPrice()
        {
           return _productDal.GetProductAvgPrice();
        }

        public int TGetProductCount()
        {
            return _productDal.GetProductCount();
        }

        public int TGetProductCountByCategoryName(string categoryName)
        {
            return _productDal.GetProductCountByCategoryName(categoryName);
        }

        public string TGetProductNameByMaxPrice()
        {
            return _productDal.GetProductNameByMaxPrice();
        }

        public string TGetProductNameByMinPrice()
        {
            return _productDal.GetProductNameByMinPrice();
        }

        public decimal TGetProductPriceByElektronik()
        {
          return _productDal.GetProductPriceByElektronik();
        }

        public List<ProductDto> TGetProductsWithCategories()
        {
            return _productDal.GetProductsWithCategories();
        }

        public void TUpdate(Product Entity)
        {
            _productDal.Update(Entity);
        }
    }
}
