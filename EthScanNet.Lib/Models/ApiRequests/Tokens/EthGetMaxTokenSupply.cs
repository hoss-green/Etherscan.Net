using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Tokens;
using EthScanNet.Lib.Models.EthModels;

namespace EthScanNet.Lib.Models.ApiRequests.Tokens
{
    internal class EthGetMaxTokenSupply : EthTokenRequest
    {
        internal EthGetMaxTokenSupply(EthAddress contractAddress) 
            : base(contractAddress, EthModules.Stats, EthActions.TokenSupply, typeof(EthApiTokenSupply))
        {
        }
    }
}