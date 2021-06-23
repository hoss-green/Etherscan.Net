using System;
using EthScanNet.Lib.Enums;

namespace EthScanNet.Lib.Models.ApiRequests.Transactions
{
    internal class EthCheckTransactionReceiptStatus : EScanRequest
    {
        internal EthCheckTransactionReceiptStatus(string txHash, EScanClient eScanClient, Type responseType, EScanModules module, EScanActions action) : base(eScanClient, responseType, module, action)
        {
            
        }
    }
}