using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EScan;
using EthScanNet.Lib.Models.Interfaces;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EScanGetNormalTransactions : EScanAccountRequest, IPaginationResponse
    {
        public int? Page { get; set; }
        public int? Offset { get; set; }
        public ulong? StartBlock { get; private set; }
        public ulong? EndBlock { get; private set; }
        public EScanGetNormalTransactions(EScanAddress address, ulong? startBlock, ulong? endBlock, int? page, int? offset, EScanClient eScanClient)
            : base(address, eScanClient, EScanModules.Account, EScanActions.TxList, typeof(EScanTransactions))
        {
            this.StartBlock = startBlock;
            this.EndBlock = endBlock;
            this.Page = page;
            this.Offset = offset;
        }
        
    }
}