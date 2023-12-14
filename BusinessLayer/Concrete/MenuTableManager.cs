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
            _menuTableDal.Add(Entity);
        }

        public void TDelete(MenuTable Entity)
        {
            _menuTableDal.Delete(Entity);
        }

        public List<MenuTable> TGetAll()
        {
            return _menuTableDal.GetAll();
        }

        public MenuTable TGetById(int id)
        {
            return _menuTableDal.GetById(id);
        }

        public int TMenuTableCount()
        {
            return _menuTableDal.MenuTableCount();
        }

        public void TUpdate(MenuTable Entity)
        {
            _menuTableDal.Update(Entity);
        }
    }
}
