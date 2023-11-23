using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TAdd(Booking Entity)
        {
          _bookingDal.Add(Entity);
        }

        public void TDelete(Booking Entity)
        {
           _bookingDal.Delete(Entity);
        }

        public List<Booking> TGetAll()
        {
            return _bookingDal.GetAll();
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public void TUpdate(Booking Entity)
        {
            _bookingDal.Update(Entity);
        }
    }
}
