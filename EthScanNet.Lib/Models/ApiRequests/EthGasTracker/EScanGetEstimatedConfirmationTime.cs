using EthScanNet.Lib.Enums;
using EScanDateTime = EthScanNet.Lib.Models.EScan.EScanDateTime;

namespace EthScanNet.Lib.Models.ApiRequests.EthGasTracker
{
    internal class EScanGetEstimatedConfirmationTime : EScanGasRequest
    {
        public long GasPrice { get; set; }
            
        internal EScanGetEstimatedConfirmationTime(long gasPrice, EScanClient eScanClient) :
            base(eScanClient, EScanActions.GasEstimate, typeof(EScanDateTime))
        {
            this.GasPrice = gasPrice;
        }
    }
}