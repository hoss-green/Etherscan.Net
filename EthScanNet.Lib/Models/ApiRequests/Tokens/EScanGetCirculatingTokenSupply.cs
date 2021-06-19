using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Tokens;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Tokens
{
    internal class EScanGetCirculatingTokenSupply : EthTokenRequest
    {
        internal EScanGetCirculatingTokenSupply(EScanAddress contractAddress) 
            : base(contractAddress, EthModules.Stats, EthActions.TokenCSupply, typeof(EScanTokenSupply))
        {
        }
    }
}