using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.EScan
{
    internal class EScanGenericResponse
    {
        [JsonProperty("Status")]
        public string Status { get; set; }
        
        [JsonProperty("Message")]
        public string Message { get; set; }
        
        [JsonProperty("Result")]
        public object ResultMessage { get; set; }
    }
}