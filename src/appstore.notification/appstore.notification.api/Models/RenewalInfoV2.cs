using Newtonsoft.Json;

namespace appstore.notification.api.Models
{
    public class RenewalInfoV2
    {
        [JsonProperty("autoRenewProductId")]
        public string AutoRenewProductId { get; set; }

        [JsonProperty("autoRenewStatus")]
        public AutoRenewStatus AutoRenewStatus { get; set; }

        [JsonProperty("expirationIntent")]
        public ExpirationIntent ExpirationIntent { get; set; }

        [JsonProperty("gracePeriodExpiresDate")]
        public long GracePeriodExpiresDate { get; set; }

        [JsonProperty("isInBillingRetryPeriod")]
        public bool IsInBillingRetryPeriod { get; set; }

        [JsonProperty("offerIdentifier")]
        public string OfferIdentifier { get; set; }

        [JsonProperty("offerType")]
        public OfferType OfferType { get; set; }

        [JsonProperty("originalTransactionId")]
        public string OriginalTransactionId { get; set; }

        [JsonProperty("priceIncreaseStatus")]
        public PriceConsent PriceIncreaseStatus { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("signedDate")]
        public long SignatureDate { get; set; }
    }
}
