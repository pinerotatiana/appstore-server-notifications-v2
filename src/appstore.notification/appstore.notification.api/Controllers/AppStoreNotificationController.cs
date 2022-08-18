using appstore.notification.api.Interfaces;
using appstore.notification.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace appstore.notification.api.Controllers
{
    [Route("notification")]
    public class AppStoreNotificationController : Controller
    {
        private readonly INotificationProcessor _notificationProcessor;

        public AppStoreNotificationController(INotificationProcessor notificationProcessor)
        {
            _notificationProcessor = notificationProcessor;
        }

        [HttpPost("appstore")]
        public ActionResult Notification([FromBody]  AppleNotification appleNotification)
        {
            try
            {
                _notificationProcessor.Process(appleNotification);
                
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
