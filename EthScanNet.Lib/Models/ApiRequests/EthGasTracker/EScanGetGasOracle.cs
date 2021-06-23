using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;

namespace EthScanNet.Lib.Models.ApiRequests.EthGasTracker
{
    internal class EScanGetGasOracle : EScanGasRequest
    {
        internal EScanGetGasOracle(EScanClient eScanClient) :
            base(eScanClient, EScanActions.GasTracker, typeof(EScanGasOracle))
        {
            
        }
    }
}