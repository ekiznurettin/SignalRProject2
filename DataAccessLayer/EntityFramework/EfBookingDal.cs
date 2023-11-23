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
    }
}
