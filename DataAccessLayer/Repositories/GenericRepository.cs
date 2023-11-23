using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly SignalRContext _context;

        public GenericRepository(SignalRContext context)
        {
            _context = context;
        }

        public void Add(T Entity)
        {
            _context.Add(Entity);
            _context.SaveChanges();
        }

        public void Delete(T Entity)
        {
            _context.Remove(Entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
          return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
           return _context.Set<T>().Find(id);
        }

        public void Update(T Entity)
        {
           _context.Update(Entity);
            _context.SaveChanges();
        }
    }
}
