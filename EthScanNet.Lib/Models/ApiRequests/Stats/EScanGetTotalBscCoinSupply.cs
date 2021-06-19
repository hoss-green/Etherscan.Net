using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Stats;

namespace EthScanNet.Lib.Models.ApiRequests.Stats
{
    internal class EScanGetTotalBscCoinSupply : EScanRequest
    {
        public EScanGetTotalBscCoinSupply() 
            : base(typeof(EScanTotalCoinSupply),EthModules.Stats, EthActions.BncScanSpecific.BnbSupply)
        {
        }
    }
}