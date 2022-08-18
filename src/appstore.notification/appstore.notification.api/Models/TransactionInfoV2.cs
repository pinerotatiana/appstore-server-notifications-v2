using Newtonsoft.Json;

namespace appstore.notification.api.Models
{
    public class TransactionInfoV2
    {
        [JsonProperty("appAccountToken")]
        public string AppAccountToken { get; set; }

        [JsonProperty("bundleId")]
        public string BundleId { get; set; }

        [JsonProperty("expiresDate")]
        public long ExpiresDate { get; set; }

        [JsonProperty("inAppOwnershipType")]
        public OwnershipType InAppOwnershipType { get; set; }

        [JsonProperty("isUpgraded")]
        public bool IsUpgraded { get; set; }

        [JsonProperty("offerIdentifier")]
        public string OfferIdentifier { get; set; }

        [JsonProperty("offerType")]
        public OfferType OfferType { get; set; }

        [JsonProperty("originalPurchaseDate")]
        public long OriginalPurchaseDate { get; set; }

        [JsonProperty("originalTransactionId")]
        public long OriginalTransactionId { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("purchaseDate")]
        public long PurchaseDate { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("revocationDate")]
        public long RevocationDate { get; set; }

        [JsonProperty("revocationReason")]
        public CancellationReason RevocationReason { get; set; }

        [JsonProperty("subscriptionGroupIdentifier")]
        public string SubscriptionGroupIdentifier { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("type")]
        public PurchaseType Type { get; set; }

        [JsonProperty("webOrderLineItemId")]
        public string WebOrderLineItemId { get; set; }

        [JsonProperty("signedDate")]
        public long SignatureDate { get; set; }
    }
}
