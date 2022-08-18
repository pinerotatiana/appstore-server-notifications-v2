using Newtonsoft.Json;

namespace appstore.notification.api.Models
{
    public class NotificationV2
    {
        [JsonProperty("notificationType")]
        public NotificationType NotificationType { get; set; }

        [JsonProperty("subtype")]
        public NotificationSubtype Subtype { get; set; }

        [JsonProperty("notificationUUID")]
        public string NotificationUUID { get; set; }

        [JsonProperty("notificationVersion")]
        public string NotificationVersion { get; set; }

        [JsonProperty("data")]
        public NotificationV2Data Data { get; set; }
    }
}
