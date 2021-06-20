using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EScanGetAccountBalance : EScanAccountRequest
    {
        public EScanGetAccountBalance(EScanAddress address) 
            : base(address, EScanModules.Account, EScanActions.Balance, typeof(EScanBalance))
        {
        }
    }
}