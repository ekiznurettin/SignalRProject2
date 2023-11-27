using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
           _categoryDal= categoryDal;
        }

        public int TGetCategoryCount()
        {
            return _categoryDal.GetCategoryCount();
        }

        public void TAdd(Category Entity)
        {
            _categoryDal.Add(Entity);
        }

        public void TDelete(Category Entity)
        {
            _categoryDal.Delete(Entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TUpdate(Category Entity)
        {
            _categoryDal.Update(Entity);
        }

        public int TGetActiveCategoryCount()
        {
            return _categoryDal.GetActiveCategoryCount();
                }

        public int TGetPassiveCategoryCount()
        {
            return _categoryDal.GetPassiveCategoryCount();
        }
    }
}
