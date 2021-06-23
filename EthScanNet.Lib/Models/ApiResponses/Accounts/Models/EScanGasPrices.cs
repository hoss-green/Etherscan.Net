using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts.Models
{
    public class EScanGasPrices : EScanResponse
    {
        [JsonProperty("LastBlock")]
        public string LastBlock { get; set; }

        [JsonProperty("SafeGasPrice")]
        public string SafeGasPrice { get; set; }

        [JsonProperty("ProposeGasPrice")]
        public string ProposeGasPrice { get; set; }

        [JsonProperty("FastGasPrice")]
        public string FastGasPrice { get; set; }
    }
}