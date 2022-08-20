using appstore.notification.api.Models;

namespace appstore.notification.api.Interfaces
{
    public interface ISubsciptionService
    {
        void Update(NotificationV2 decodedPayload, RenewalInfoV2? renewalInfo, TransactionInfoV2? transactionInfo);
    }
}
