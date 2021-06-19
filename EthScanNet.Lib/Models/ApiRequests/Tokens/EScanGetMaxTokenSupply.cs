using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Tokens;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Tokens
{
    internal class EScanGetMaxTokenSupply : EthTokenRequest
    {
        internal EScanGetMaxTokenSupply(EScanAddress contractAddress) 
            : base(contractAddress, EthModules.Stats, EthActions.TokenSupply, typeof(EScanTokenSupply))
        {
        }
    }
}