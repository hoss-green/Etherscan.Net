using System;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts
{
    public class EScanDateTime : EScanResponse
    {
        [JsonProperty("result")]
        public long TimeSeconds { get; set; }

        [JsonIgnore]
        public TimeSpan Time => TimeSpan.FromSeconds(TimeSeconds);
    }
}