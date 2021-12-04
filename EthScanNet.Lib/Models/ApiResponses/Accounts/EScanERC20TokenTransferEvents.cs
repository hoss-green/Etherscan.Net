using EthScanNet.Lib.Models.ApiResponses.Accounts.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts
{
    public class EScanERC20TokenTransferEvents : EScanResponse
    {
        [JsonProperty("result")]
        public List<EScanTokenTransferEvent> ERC20TokenTransferEvents { get; set; }
    }
}
