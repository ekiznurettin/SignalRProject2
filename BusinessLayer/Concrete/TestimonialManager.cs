using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial Entity)
        {
            _testimonialDal.Add(Entity);
        }

        public void TDelete(Testimonial Entity)
        {
            _testimonialDal.Delete(Entity);
        }

        public List<Testimonial> TGetAll()
        {
           return _testimonialDal.GetAll();
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.GetById  (id);
        }

        public void TUpdate(Testimonial Entity)
        {
            _testimonialDal.Update(Entity);
        }
    }
}
