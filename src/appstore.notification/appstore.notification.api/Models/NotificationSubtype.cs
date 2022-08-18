using System.Runtime.Serialization;

namespace appstore.notification.api.Models
{
    public enum NotificationSubtype
    {
        [EnumMember(Value = "INITIAL_BUY")] INITIAL_BUY,
        
        [EnumMember(Value = "RESUBSCRIBE")] RESUBSCRIBE,
        
        [EnumMember(Value = "DOWNGRADE")] DOWNGRADE,
        
        [EnumMember(Value = "UPGRADE")] UPGRADE,
        
        [EnumMember(Value = "AUTO_RENEW_ENABLED")] AUTO_RENEW_ENABLED,
        
        [EnumMember(Value = "AUTO_RENEW_DISABLED")] AUTO_RENEW_DISABLED,
        
        [EnumMember(Value = "VOLUNTARY")] VOLUNTARY,
        
        [EnumMember(Value = "BILLING_RETRY")] BILLING_RETRY,
        
        [EnumMember(Value = "PRICE_INCREASE")] PRICE_INCREASE,
        
        [EnumMember(Value = "GRACE_PERIOD")] GRACE_PERIOD,
        
        [EnumMember(Value = "BILLING_RECOVERY")] BILLING_RECOVERY,
        
        [EnumMember(Value = "PENDING")] PENDING,
        
        [EnumMember(Value = "ACCEPTED")] ACCEPTED,
    }
}