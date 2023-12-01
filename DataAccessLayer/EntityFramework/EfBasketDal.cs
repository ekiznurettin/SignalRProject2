using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Dtos.BasketDtos;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.Metrics;

namespace DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(SignalRContext context) : base(context)
        {
        }

        public List<Basket> GetBasketByMenuTableId(int tableId)
        {
            using (var context = new SignalRContext())
            {
                var values = context.Baskets.Where(x => x.MenuTableId == tableId).Include(y => y.Product).Include(z => z.MenuTable).ToList();
                return values;
            }
        }
        public List<ResultBasketDto> BasketListByMenuTableWithProductName(int tableId)
        {
            using (var context = new SignalRContext())
            {
                var values = context.Baskets.Where(x => x.MenuTableId == tableId).Include(y => y.Product).Include(z => z.MenuTable).Select(l => new ResultBasketDto
                {
                    Count = l.Count,
                    Id = l.Id,
                    MenuTableName = l.MenuTable.Name,
                    Price = l.Price,
                    ProductName = l.Product.Name,
                    TotalPrice = l.TotalPrice
                }).ToList();
                return values;
            }
        }
    }
}
