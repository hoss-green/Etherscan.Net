using System.Numerics;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Stats
{
    public class EScanTotalCoinSupply : EScanResponse
    {
        [JsonProperty("result")]
        public BigInteger TotalCoin { get; set; }
    }
}