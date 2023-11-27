using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {
        public int TGetCategoryCount();
        public int TGetActiveCategoryCount();
        public int TGetPassiveCategoryCount();
    }
}
