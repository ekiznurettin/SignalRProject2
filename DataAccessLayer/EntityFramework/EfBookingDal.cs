using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(SignalRContext context) : base(context)
        {
        }

        public void BookingStatusApproved(int id)
        {
            using (var db = new SignalRContext())
            {
                var value = db.Bookings.Find(id);
                value.Description = "Rezervasyon Onaylandı";
                db.SaveChanges();
            }
        }

        public void BookingStatusCanceled(int id)
        {
            using (var db = new SignalRContext())
            {
                var value = db.Bookings.Find(id);
                value.Description = "Rezervasyon iptal Edildi";
                db.SaveChanges();
            }
        }
    }
}
