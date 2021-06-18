using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EthModels;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EthGetMinedBlocks : EthAccountRequest
    {

        public EthGetMinedBlocks(EthAddress address) 
            : base(address,EthModules.Account, EthActions.GetMinedBlocks, typeof(EthApiMinedBlocks))
        {
        }
    }
}