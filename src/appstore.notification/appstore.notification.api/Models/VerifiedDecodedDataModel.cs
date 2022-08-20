namespace appstore.notification.api.Models
{
    public class VerifiedDecodedDataModel<TDataModel>
    {
        public TDataModel? DecodedPayload { get; set; }

        public bool IsValid { get; set; }
    }
}
