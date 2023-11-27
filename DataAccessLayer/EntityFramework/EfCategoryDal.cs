using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SignalRContext context) : base(context)
        {
        }

        public int GetActiveCategoryCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Categories.Where(x => x.Status == true).Count();
            }
        }

        public int GetCategoryCount()
        {
            using (var context= new SignalRContext())
            {
                return context.Categories.Count();
            }
        }

        public int GetPassiveCategoryCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Categories.Where(x => x.Status == false).Count();
            }
        }
    }
}
