using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Contracts
{
    public class EScanAbiResponse : EScanResponse
    {
        [JsonProperty("result")]
        public string ABI { get; set; }
    }
}
