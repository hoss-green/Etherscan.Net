using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiRequests.Tokens;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EScanGetTokenBalanceForAccount : EScanAccountRequest
    {
        public EScanAddress ContractAddress { get; set; }
        //public string Tag = "Latest";
        
        internal EScanGetTokenBalanceForAccount(EScanAddress address, EScanAddress contractAddress, EScanClient eScanClient) 
            : base(address, eScanClient, EScanModules.Account, EScanActions.TokenBalance, typeof(EScanBalance))
        {
            this.ContractAddress = contractAddress;
        }
        
    }
}