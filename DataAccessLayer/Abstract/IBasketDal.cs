using EntityLayer.Dtos.BasketDtos;
using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IBasketDal:IGenericDal<Basket>
    {
        List<Basket> GetBasketByMenuTableId(int tableId);
        List<ResultBasketDto> BasketListByMenuTableWithProductName(int tableId);
    }
}
