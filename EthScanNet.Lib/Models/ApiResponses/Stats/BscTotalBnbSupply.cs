using System.Numerics;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Stats
{
    public class EthApiTotalBnbSupply : EthApiResponse
    {
        [JsonProperty("result")]
        public BigInteger TotalBnb { get; set; }
    }
}