using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Contracts
{
    public class EScanSourceCodeVerificationResponse : EScanResponse
    {
        [JsonProperty("result")]
        public string Guid { get; set; }
    }
}
