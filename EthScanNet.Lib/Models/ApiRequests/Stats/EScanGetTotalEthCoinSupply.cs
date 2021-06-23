using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Stats;

namespace EthScanNet.Lib.Models.ApiRequests.Stats
{
    internal class EScanGetTotalEthCoinSupply : EScanRequest
    {
        public EScanGetTotalEthCoinSupply(EScanClient eScanClient) 
            : base(eScanClient, typeof(EScanTotalCoinSupply),EScanModules.Stats, EScanActions.EtherscanSpecific.EthSupply)
        {
        }
    }
}