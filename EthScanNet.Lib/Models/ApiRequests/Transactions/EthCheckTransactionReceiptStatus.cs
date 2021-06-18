using System;
using EthScanNet.Lib.Enums;

namespace EthScanNet.Lib.Models.ApiRequests.Transactions
{
    internal class EthCheckTransactionReceiptStatus : EthApiRequest
    {
        internal EthCheckTransactionReceiptStatus(string txHash, Type responseType, EthModules module, EthActions action) : base(responseType, module, action)
        {
            
        }
    }
}