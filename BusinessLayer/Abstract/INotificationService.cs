using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface INotificationService:IGenericService<Notification>
    {
        int TNotificationCountByStatusFalse();
        List<Notification> TNotificationByStatusFalse();

		void TNotificationChangeToTrue(int id);
		void TNotificationChangeToFalse(int id);
	}
}
