using Newtonsoft.Json;

namespace appstore.notification.api.Models
{
    public class AppleNotification
    {
        [JsonProperty("signedPayload")]
        public string SignedPayload { get; set; } = string.Empty;
    }
}
