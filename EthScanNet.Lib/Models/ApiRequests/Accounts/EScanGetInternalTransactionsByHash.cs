using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EScan;
using EthScanNet.Lib.Models.Interfaces;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EScanGetInternalTransactionsByHash : EScanRequest
    {
        public string TxHash { get; set; }
        
        public EScanGetInternalTransactionsByHash(string txHash, EScanClient eScanClient)
            :base(eScanClient,typeof(EScanTransactions),EScanModules.Account, EScanActions.TxListInternal)
        {
            this.TxHash = txHash;
        }

        
    }
}