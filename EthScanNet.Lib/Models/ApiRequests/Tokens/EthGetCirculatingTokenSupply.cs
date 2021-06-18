using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Tokens;
using EthScanNet.Lib.Models.EthModels;

namespace EthScanNet.Lib.Models.ApiRequests.Tokens
{
    internal class EthGetCirculatingTokenSupply : EthTokenRequest
    {
        internal EthGetCirculatingTokenSupply(EthAddress contractAddress) 
            : base(contractAddress, EthModules.Stats, EthActions.TokenCSupply, typeof(EthApiTokenSupply))
        {
        }
    }
}