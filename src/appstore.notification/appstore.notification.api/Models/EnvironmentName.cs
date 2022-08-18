using System.Runtime.Serialization;

namespace appstore.notification.api.Models
{
    public enum EnvironmentName
    {
        [EnumMember(Value = "Sandbox")]
        Sandbox = 0,

        [EnumMember(Value = "PROD")]
        PROD = 1
    }
}
