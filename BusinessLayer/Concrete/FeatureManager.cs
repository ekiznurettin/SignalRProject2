using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature Entity)
        {
            _featureDal.Add(Entity);
        }

        public void TDelete(Feature Entity)
        {
         _featureDal.Delete(Entity);
        }

        public List<Feature> TGetAll()
        {
           return _featureDal.GetAll();
        }

        public Feature TGetById(int id)
        {
           return _featureDal.GetById(id);
        }

        public void TUpdate(Feature Entity)
        {
            _featureDal.Update(Entity);
        }
    }
}
