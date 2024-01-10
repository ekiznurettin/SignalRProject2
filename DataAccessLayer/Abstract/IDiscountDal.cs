using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IDiscountDal:IGenericDal<Discount>
    {
        void ChangeStatusToFalse(int id);
        void ChangeStatusToTrue(int id);
    }
}
