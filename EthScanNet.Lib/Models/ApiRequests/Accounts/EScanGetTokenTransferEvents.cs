using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EScanGetTokenTransferEvents : EScanAccountRequest
    {

        public EScanGetTokenTransferEvents(EScanAddress address) 
            : base(address,EthModules.Account, EthActions.TokenNftTx, typeof(EScanTokenTransferEvents))
        {
        }
    }
}