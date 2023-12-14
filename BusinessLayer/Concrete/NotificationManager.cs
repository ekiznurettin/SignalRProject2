using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public List<Notification> TNotificationByStatusFalse()
        {
            return _notificationDal.NotificationByStatusFalse();
        }

        public void TAdd(Notification Entity)
        {
            _notificationDal.Add(Entity);
        }

        public void TDelete(Notification Entity)
        {
           _notificationDal.Delete(Entity);
        }

        public List<Notification> TGetAll()
        {
            return _notificationDal.GetAll();
        }

        public Notification TGetById(int id)
        {
          return _notificationDal.GetById(id);
        }

        public int TNotificationCountByStatusFalse()
        {
           return _notificationDal.NotificationCountByStatusFalse();
        }

        public void TUpdate(Notification Entity)
        {
            _notificationDal.Update(Entity);
        }

		public void TNotificationChangeToTrue(int id)
		{
            _notificationDal.NotificationChangeToTrue(id);
		}

		public void TNotificationChangeToFalse(int id)
		{
            _notificationDal.NotificationChangeToFalse(id);
        }
	}
}
