using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EScanGetInternalTransactions : EScanAccountRequest
    {
        public EScanGetInternalTransactions(EScanAddress address) 
            : base(address,EScanModules.Account, EScanActions.TxListInternal, typeof(EScanTransactions))
        {
        }
    }
}