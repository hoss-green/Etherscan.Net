using System.Numerics;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts.Models
{
    public class EthMinedBlock
    {
        [JsonProperty("blockNumber")]
        public BigInteger BlockNumber { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("blockReward")]
        public BigInteger BlockReward { get; set; }
    }
}