using Newtonsoft.Json;

namespace appstore.notification.api.Models
{
    public class NotificationV2Data
    {
        [JsonProperty("appAppleId")]
        public string AppAppleId { get; set; }
        
        [JsonProperty("bundleId")]
        public string BundleId { get; set; }
        
        [JsonProperty("bundleVersion")]
        public string BundleVersion { get; set; }
        
        [JsonProperty("environment")]
        public EnvironmentName Environment { get; set; }
        
        [JsonProperty("signedRenewalInfo")]
        public string SignedRenewalInfo { get; set; }
        
        [JsonProperty("signedTransactionInfo")]
        public string SignedTransactionInfo { get; set; }
    }
}