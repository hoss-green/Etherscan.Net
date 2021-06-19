using System.Numerics;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts
{
    public class EScanBalance : EScanResponse
    {
        [JsonProperty("result")]
        public BigInteger Balance { get; set; }
    }
}