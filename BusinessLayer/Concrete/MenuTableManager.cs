using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class MenuTableManager : IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;

        public MenuTableManager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }

        public void TAdd(MenuTable Entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MenuTable Entity)
        {
            throw new NotImplementedException();
        }

        public List<MenuTable> TGetAll()
        {
            throw new NotImplementedException();
        }

        public MenuTable TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public int TMenuTableCount()
        {
           return _menuTableDal.MenuTableCount();
        }

        public void TUpdate(MenuTable Entity)
        {
            throw new NotImplementedException();
        }
    }
}
