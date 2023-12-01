using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(Slider Entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Slider Entity)
        {
            throw new NotImplementedException();
        }

        public List<Slider> TGetAll()
        {
            return _sliderDal.GetAll();
        }

        public Slider TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Slider Entity)
        {
            throw new NotImplementedException();
        }
    }
}
