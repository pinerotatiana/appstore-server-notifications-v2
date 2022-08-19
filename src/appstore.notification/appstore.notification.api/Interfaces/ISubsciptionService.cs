using appstore.notification.api.Models;

namespace appstore.notification.api.Interfaces
{
    public interface ISubsciptionService
    {
        void Update(NotificationV2 validResult, RenewalInfoV2? renewalInfoV2, VerifiedDecodedDataModel<TransactionInfoV2> transactionInfoV2);
    }
}
