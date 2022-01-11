using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Contracts
{
    public class EScanABIResponse : EScanResponse
    {
        [JsonProperty("result")]
        public string ABI { get; set; }
    }
}
