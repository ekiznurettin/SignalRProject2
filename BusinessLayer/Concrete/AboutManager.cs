using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutservice
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About Entity)
        {
            _aboutDal.Add(Entity);
        }

        public void TDelete(About Entity)
        {
          _aboutDal.Delete(Entity);
        }

        public List<About> TGetAll()
        {
          return _aboutDal.GetAll();
        }

        public About TGetById(int id)
        {
        return _aboutDal.GetById(id);
        }

        public void TUpdate(About Entity)
        {
          _aboutDal.Update(Entity);
        }
    }
}
