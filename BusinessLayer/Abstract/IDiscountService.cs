using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IDiscountService:IGenericService<Discount>
    {
        void TChangeStatusToFalse(int id);
        void TChangeStatusToTrue(int id);
    }
}
