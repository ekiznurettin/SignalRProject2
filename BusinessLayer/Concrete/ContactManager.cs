using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact Entity)
        {
            _contactDal.Add(Entity);
        }

        public void TDelete(Contact Entity)
        {
           _contactDal.Delete(Entity);
        }

        public List<Contact> TGetAll()
        {
           return _contactDal.GetAll();
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public void TUpdate(Contact Entity)
        {
           _contactDal.Update(Entity);
        }
    }
}
