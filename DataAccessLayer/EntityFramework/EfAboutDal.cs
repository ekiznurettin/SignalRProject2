using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(SignalRContext context) : base(context)
        {
        }
    }
}
