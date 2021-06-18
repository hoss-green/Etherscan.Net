using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EthModels;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EthGetBnbAccountBalance : EthAccountRequest
    {
        public EthGetBnbAccountBalance(EthAddress address) 
            : base(address, EthModules.Account, EthActions.Balance, typeof(EthApiBalance))
        {
        }
    }
}