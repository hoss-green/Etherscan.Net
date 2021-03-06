using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EScanGetMinedBlocks : EScanAccountRequest
    {
        public EScanGetMinedBlocks(EScanAddress address, EScanClient eScanClient)
            : base(address, eScanClient, EScanModules.Account, EScanActions.GetMinedBlocks, typeof(EScanMinedBlocks))
        {
        }
    }
}