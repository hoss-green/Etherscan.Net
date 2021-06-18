using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EthModels;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EthGetInternalTransactions : EthAccountRequest
    {
        public EthGetInternalTransactions(EthAddress address) 
            : base(address,EthModules.Account, EthActions.TxListInternal, typeof(EthApiTransactions))
        {
        }
    }
}