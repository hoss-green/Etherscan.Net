using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses
{
    public class EthApiResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}