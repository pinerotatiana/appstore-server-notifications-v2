using System.Runtime.Serialization;

namespace appstore.notification.api.Models
{
    public enum OwnershipType
    {
        [EnumMember(Value = "PURCHASED")]
        Purchased = 1,

        [EnumMember(Value = "FAMILY_SHARED")]
        FamilyShared = 2
    }
}