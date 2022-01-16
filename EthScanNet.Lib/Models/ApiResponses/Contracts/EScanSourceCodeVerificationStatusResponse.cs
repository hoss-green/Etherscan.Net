using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Contracts
{
    public class EScanSourceCodeVerificationStatusResponse : EScanResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
