using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.EScan
{
    public enum EScanMessageTypes
    {
        [JsonProperty("OK")]
        Ok,
        
        [JsonProperty("NOTOK")]
        NotOk
    }
}