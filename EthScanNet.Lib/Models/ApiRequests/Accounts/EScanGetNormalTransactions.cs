using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EScanGetNormalTransactions : EScanAccountRequest
    {

        public EScanGetNormalTransactions(EScanAddress address) 
            : base(address,EScanModules.Account, EScanActions.TxList, typeof(EScanTransactions))
        {
        }
    }
}