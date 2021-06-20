using System;
using EthScanNet.Lib.Enums;

namespace EthScanNet.Lib.Models.ApiRequests.Transactions
{
    internal class EthCheckTransactionReceiptStatus : EScanRequest
    {
        internal EthCheckTransactionReceiptStatus(string txHash, Type responseType, EScanModules module, EScanActions action) : base(responseType, module, action)
        {
            
        }
    }
}