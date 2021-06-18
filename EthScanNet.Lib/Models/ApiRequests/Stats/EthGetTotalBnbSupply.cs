using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Stats;

namespace EthScanNet.Lib.Models.ApiRequests.Stats
{
    internal class EthGetTotalBnbSupply : EthApiRequest
    {
        public EthGetTotalBnbSupply() 
            : base(typeof(EthApiTotalBnbSupply),EthModules.Stats, EthActions.BnbSupply)
        {
        }
    }
}