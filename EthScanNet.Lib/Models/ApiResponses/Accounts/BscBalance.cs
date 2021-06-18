using System.Numerics;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts
{
    public class EthApiBalance : EthApiResponse
    {
        [JsonProperty("result")]
        public BigInteger BnbBalance { get; set; }
    }
}