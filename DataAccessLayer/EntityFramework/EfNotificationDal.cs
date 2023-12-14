using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationDal(SignalRContext context) : base(context)
        {
        }

        public List<Notification> NotificationByStatusFalse()
        {
            using (var db = new SignalRContext())
            {
                return db.Notifications.Where(s => s.Status == false).ToList();
            }
        }

		public void NotificationChangeToFalse(int id)
		{
			using (var db = new SignalRContext())
			{
                var value = db.Notifications.Find(id);
                value.Status = false;
                db.SaveChanges();
			}
		}

		public void NotificationChangeToTrue(int id)
		{
			using (var db = new SignalRContext())
			{
				var value = db.Notifications.Find(id);
				value.Status = true;
				db.SaveChanges();
			}
		}

		public int NotificationCountByStatusFalse()
        {
            using (var db = new SignalRContext())
            {
                return db.Notifications.Where(s => s.Status == false).Count();
            }
        }
    }
}
