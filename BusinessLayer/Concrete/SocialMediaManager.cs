using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocialMedia Entity)
        {
            _socialMediaDal.Add(Entity);
        }

        public void TDelete(SocialMedia Entity)
        {
            _socialMediaDal.Delete(Entity);
        }

        public List<SocialMedia> TGetAll()
        {
            return _socialMediaDal.GetAll();
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public void TUpdate(SocialMedia Entity)
        {
            _socialMediaDal.Update(Entity);
        }
    }
}
