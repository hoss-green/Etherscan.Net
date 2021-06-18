using System.Collections.Generic;
using EthScanNet.Lib.Models.ApiResponses.Accounts.Models;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts
{
    public class EthApiTokenTransferEvents : EthApiResponse
    {
        [JsonProperty("result")]
        public List<BscTokenTransferEvent> TokenTransferEvents { get; set; }
    }
}