using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface INotificationDal:IGenericDal<Notification>
    {
        int NotificationCountByStatusFalse();
        List<Notification> NotificationByStatusFalse();
        void NotificationChangeToTrue(int id);
        void NotificationChangeToFalse(int id);
    }
}
