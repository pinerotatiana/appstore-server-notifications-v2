using System.Runtime.Serialization;

namespace appstore.notification.api.Models
{
    public enum NotificationType
    {
        [EnumMember(Value = "CANCEL")] CANCEL = 1,
        
        [EnumMember(Value = "CONSUMPTION_REQUEST")] CONSUMPTION_REQUEST,
        
        [EnumMember(Value = "DID_CHANGE_RENEWAL_PREF")] DID_CHANGE_RENEWAL_PREF,
        
        [EnumMember(Value = "DID_CHANGE_RENEWAL_STATUS")] DID_CHANGE_RENEWAL_STATUS,
                
        [EnumMember(Value = "DID_FAIL_TO_RENEW")] DID_FAIL_TO_RENEW,
        
        [EnumMember(Value = "DID_RECOVER")] DID_RECOVER,
        
        [EnumMember(Value = "DID_RENEW")] DID_RENEW,
        
        [EnumMember(Value = "INITIAL_BUY")] INITIAL_BUY,
        
        [EnumMember(Value = "INTERACTIVE_RENEWAL")] INTERACTIVE_RENEWAL,
        
        [EnumMember(Value = "PRICE_INCREASE_CONSENT")] PRICE_INCREASE_CONSENT,
        
        [EnumMember(Value = "REFUND")] REFUND,
        
        [EnumMember(Value = "REVOKE")] REVOKE,
        
        [Obsolete("Use 'DID_RECOVER' instead")]
        [EnumMember(Value = "RENEWAL")] RENEWAL,
    }
}