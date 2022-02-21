using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Stats;

namespace EthScanNet.Lib.Models.ApiRequests.Stats
{
    internal class EScanGetTotalPolygonCoinSupply : EScanRequest
    {
        public EScanGetTotalPolygonCoinSupply(EScanClient eScanClient) 
            : base(eScanClient, typeof(EScanTotalCoinSupply),EScanModules.Stats, EScanActions.PolygonScanSpecific.MaticSupply)
        {
        }
    }
}