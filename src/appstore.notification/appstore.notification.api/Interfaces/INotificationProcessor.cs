using appstore.notification.api.Models;

namespace appstore.notification.api.Interfaces
{
    public interface INotificationProcessor
    {

        /// <summary>Validates and translates the notification into a change</summary>
        void Process(AppleNotification notification);
    }
}
