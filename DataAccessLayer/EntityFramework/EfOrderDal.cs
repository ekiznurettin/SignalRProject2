using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(SignalRContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Orders.Where(x=>x.Description=="Müşteri Masada").Count();
            }
        }

        public decimal LastOrderPrice()
        {
            using (var context = new SignalRContext())
            {
                return context.Orders.OrderByDescending(x => x.Id).Take(1).Select(y => y.TotalPrice).FirstOrDefault();
            }
        }

        public int PassiveOrderCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Orders.Where(x => x.Description == "Müşteri Masada Değil").Count();
            }
        }

        public decimal TodayTotalPrice()
        {
            using (var context = new SignalRContext())
            {
                return context.Orders.Where(x => x.Date == DateTime.Parse(DateTime.Now.ToShortDateString())).Sum(y => y.TotalPrice);
            }
        }

        public int TotalOrderCount()
        {
            using (var context = new SignalRContext()) {
                return context.Orders.Count();
            }
        }
    }
}
