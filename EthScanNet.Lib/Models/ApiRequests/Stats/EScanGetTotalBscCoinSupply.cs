using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Stats;

namespace EthScanNet.Lib.Models.ApiRequests.Stats
{
    internal class EScanGetTotalBscCoinSupply : EScanRequest
    {
        public EScanGetTotalBscCoinSupply(EScanClient eScanClient) 
            : base(eScanClient, typeof(EScanTotalCoinSupply),EScanModules.Stats, EScanActions.BncScanSpecific.BnbSupply)
        {
        }
    }
}