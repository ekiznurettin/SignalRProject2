using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public EfDiscountDal(SignalRContext context) : base(context)
        {
        }

        public void ChangeStatusToFalse(int id)
        {
            using (var db = new SignalRContext())
            {
                var value = db.Discounts.Find(id);
                value.Status = false;
                db.SaveChanges();
            }
        }

        public void ChangeStatusToTrue(int id)
        {
            using (var db = new SignalRContext())
            {
                var value = db.Discounts.Find(id);
                value.Status = true;
                db.SaveChanges();
            }
        }
    }
}
