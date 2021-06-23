using System;
using EthScanNet.Lib.Enums;

namespace EthScanNet.Lib.Models.ApiRequests.EthGasTracker
{
    internal class EScanGasRequest : EScanRequest
    {
        internal EScanGasRequest(EScanClient eScanClient, EScanActions action, Type returnType) : base(eScanClient, returnType, EScanModules.GasTracker, action)
        {
        }
    }
}