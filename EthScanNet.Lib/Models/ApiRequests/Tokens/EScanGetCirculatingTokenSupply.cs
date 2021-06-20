using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Tokens;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Tokens
{
    internal class EScanGetCirculatingTokenSupply : EScanTokenRequest
    {
        internal EScanGetCirculatingTokenSupply(EScanAddress contractAddress) 
            : base(contractAddress, EScanModules.Stats, EScanActions.TokenCSupply, typeof(EScanTokenSupply))
        {
        }
    }
}