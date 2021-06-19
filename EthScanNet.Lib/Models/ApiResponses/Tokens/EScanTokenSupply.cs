using System.Numerics;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Tokens
{
    public class EScanTokenSupply : EScanResponse
    {
        [JsonProperty("result")]
        public BigInteger NumberOfTokens { get; set; } 
    }
}