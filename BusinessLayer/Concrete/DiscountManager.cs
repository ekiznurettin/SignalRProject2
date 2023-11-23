using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void TAdd(Discount Entity)
        {
            _discountDal.Add(Entity);
        }

        public void TDelete(Discount Entity)
        {
            _discountDal.Delete(Entity);
        }

        public List<Discount> TGetAll()
        {
           return _discountDal.GetAll();
        }

        public Discount TGetById(int id)
        {
            return _discountDal.GetById(id);
        }

        public void TUpdate(Discount Entity)
        {
          _discountDal.Update(Entity);
        }
    }
}
