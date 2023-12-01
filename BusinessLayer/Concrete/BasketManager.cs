using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Dtos.BasketDtos;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void TAdd(Basket Entity)
        {
            _basketDal.Add(Entity);
        }

        public List<ResultBasketDto> TBasketListByMenuTableWithProductName(int tableId)
        {
            return _basketDal.BasketListByMenuTableWithProductName(tableId);
        }

        public void TDelete(Basket Entity)
        {
            throw new NotImplementedException();
        }

        public List<Basket> TGetAll()
        {
            throw new NotImplementedException();
        }

        public List<Basket> TGetBasketByMenuTableId(int tableId)
        {
            return _basketDal.GetBasketByMenuTableId(tableId);
        }

        public Basket TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Basket Entity)
        {
            throw new NotImplementedException();
        }
    }
}
