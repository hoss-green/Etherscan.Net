using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EthModels;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EthGetNormalTransactions : EthAccountRequest
    {

        public EthGetNormalTransactions(EthAddress address) 
            : base(address,EthModules.Account, EthActions.TxList, typeof(EthApiTransactions))
        {
        }
    }
}