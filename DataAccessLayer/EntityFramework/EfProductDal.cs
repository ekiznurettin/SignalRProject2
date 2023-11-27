using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Dtos.ProductDtos;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

        public List<ProductDto> GetProductsWithCategories()
        {
            using (var context = new SignalRContext())
            {
                var values = context.Products.Include(x => x.Category).Select(y => new ProductDto
                {
                    Description = y.Description,
                    Id = y.Id,
                    ImageUrl = y.ImageUrl,
                    Name = y.Name,
                    Price = y.Price,
                    Status = y.Status,
                    CategoryName = y.Category.Name
                }).ToList();
                return values;
            }
        }

        public int GetProductCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Products.Count();
            }
        }

        public int GetProductCountByCategoryName(string categoryName)
        {
            using (var context = new SignalRContext())
            {
                return context.Products.Where(x => x.Name == categoryName).Count();
            }
        }

        public decimal GetProductAvgPrice()
        {
            using (var context = new SignalRContext())
            {
                return context.Products.Average(x => x.Price);
            }
        }

        public string GetProductNameByMaxPrice()
        {
            using (var context = new SignalRContext())
            {
                return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.Name).FirstOrDefault();
            }
        }

        public string GetProductNameByMinPrice()
        {
            using (var context = new SignalRContext())
            {
                return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.Name).FirstOrDefault();
            }
        }

        public decimal GetProductPriceByElektronik()
        {
            using (var context = new SignalRContext())
            {
                return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.Name == "Elektronik").Select(z => z.Id).FirstOrDefault())).Average(p => p.Price);
            }
        }
    }
}
