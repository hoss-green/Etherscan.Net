using System.Numerics;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Tokens
{
    public class EthApiTokenSupply : EthApiResponse
    {
        [JsonProperty("result")]
        public BigInteger NumberOfTokens { get; set; } 
    }
}