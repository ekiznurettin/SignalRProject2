using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IMenuTableDal:IGenericDal<MenuTable>
    {
        int MenuTableCount();
    }
}
