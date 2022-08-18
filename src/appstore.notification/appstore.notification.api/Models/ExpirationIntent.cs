namespace appstore.notification.api.Models
{
    public enum ExpirationIntent
    {
        Canceled = 1,
        BillingError = 2,
        NewPriceRefused = 3,
        NotPurchasable = 4,
        Unknown = 5
    }
}