namespace appstore.notification.api.Models
{
    public class JwsHeader
    {
        public string Alg { get; set; }
        public string[] X5C { get; set; }
    }
}
