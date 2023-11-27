using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public int TActiveOrderCount()
        {
          return _orderDal.ActiveOrderCount();
        }

        public void TAdd(Order Entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Order Entity)
        {
            throw new NotImplementedException();
        }

        public List<Order> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Order TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public decimal TLastOrderPrice()
        {
            return _orderDal.LastOrderPrice();
        }

        public int TPassiveOrderCount()
        {
            return _orderDal.PassiveOrderCount();
        }

        public decimal TTodayTotalPrice()
        {
            return _orderDal.TodayTotalPrice();
        }

        public int TTotalOrderCount()
        {
           return _orderDal.TotalOrderCount();
        }

        public void TUpdate(Order Entity)
        {
            throw new NotImplementedException();
        }
    }
}
