using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses
{
    public class EScanJsonRpcResponse
    {
        // ReSharper disable once StringLiteralTypo
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; }
        
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("result")]
        public object Result { get; set; }
    }
}