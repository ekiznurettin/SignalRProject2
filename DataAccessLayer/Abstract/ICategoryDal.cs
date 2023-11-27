using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        public int GetCategoryCount();
        public int GetActiveCategoryCount();
        public int GetPassiveCategoryCount();
    }
}
