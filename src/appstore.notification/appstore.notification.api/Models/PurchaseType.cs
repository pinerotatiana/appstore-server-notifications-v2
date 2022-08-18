using System.Runtime.Serialization;

namespace appstore.notification.api.Models
{
    public enum PurchaseType
    {
        [EnumMember(Value = "Auto-Renewable Subscription")] AutoRenewSub,

        [EnumMember(Value = "Non-Consumable")] NonConsumable,

        [EnumMember(Value = "Consumable")] Consumable,

        [EnumMember(Value = "Non-Renewing Subscription")] NoRenewSub,
    }
}