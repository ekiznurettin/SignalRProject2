using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            using (var context = new SignalRContext())
            {
                var values = context.Products.Include(x => x.Category).ToList();
                return values;
            }
        }
    }
}
