using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.EScan
{
    internal class EScanGenericJsonResponse
    {
        [JsonProperty("JsonRpc")]
        public string JsonRpc { get; set; }
        
        [JsonProperty("Id")]
        public int Id { get; set; }
        
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}