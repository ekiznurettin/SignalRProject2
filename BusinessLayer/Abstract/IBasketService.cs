using EntityLayer.Dtos.BasketDtos;
using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IBasketService:IGenericService<Basket>
    {
        List<Basket> TGetBasketByMenuTableId(int tableId);
        List<ResultBasketDto> TBasketListByMenuTableWithProductName(int tableId);
    }
}
