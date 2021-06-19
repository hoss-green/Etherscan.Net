using System.Collections.Generic;
using EthScanNet.Lib.Models.ApiResponses.Accounts.Models;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts
{
    public class EScanTokenTransferEvents : EScanResponse
    {
        [JsonProperty("result")]
        public List<EthTokenTransferEvent> TokenTransferEvents { get; set; }
    }
}