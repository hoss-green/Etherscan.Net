using System.Collections.Generic;
using EthScanNet.Lib.Models.ApiResponses.Accounts.Models;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts
{
    public class EthApiTransactions : EthApiResponse
    {
        [JsonProperty("result")]
        public List<BscTransaction> Transactions { get; set; }
    }
}