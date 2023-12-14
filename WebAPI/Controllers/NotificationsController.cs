using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Dtos.NotificationDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        private readonly IMapper _mapper;

        public NotificationsController(INotificationService notificationService, IMapper mapper)
        {
            _notificationService = notificationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult NotificationList()
        {
            return Ok(_notificationService.TGetAll());
        }
        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse()
        {
            return Ok(_notificationService.TNotificationCountByStatusFalse());
        }
        [HttpGet("NotificationByStatusFalse")]
        public IActionResult NotificationByStatusFalse()
        {
            return Ok(_notificationService.TNotificationByStatusFalse());
        }
        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            var notification = _mapper.Map<Notification>(createNotificationDto);
            notification.Status = false;
            notification.Date = DateTime.Now;
            _notificationService.TAdd(notification);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNotification(int id)
        {
            var value = _notificationService.TGetById(id);
            _notificationService.TDelete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetNotificationById(int id)
        {
            var value = _notificationService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult DeleteNotification(UpdateNotificationDto updateNotificationDto)
        {
            var notification = _mapper.Map<Notification>(updateNotificationDto);
            notification.Status = false;
            notification.Date = DateTime.Now;
            _notificationService.TUpdate(notification);
            return Ok();
        }

        [HttpGet("NotificationChangeToFalse/{id}")]
        public IActionResult NotificationChangeToFalse(int id)
        {
            _notificationService.TNotificationChangeToFalse(id);
            return Ok();
        }
		[HttpGet("NotificationChangeToTrue/{id}")]
		public IActionResult NotificationChangeToTrue(int id)
		{
			_notificationService.TNotificationChangeToTrue(id);
			return Ok();
		}
	}
}
