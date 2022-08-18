namespace appstore.notification.api.Models
{
    public class VerifiedDecodedDataModel<TDataModel>
    {
        public TDataModel ValidResult { get; set; }
        public bool Valid { get; set; }
    }
}
