using System.Collections.Generic;
using EthScanNet.Lib.Models.ApiResponses.Accounts.Models;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts
{
    public class EScanMinedBlocks : EScanResponse
    {
        [JsonProperty("result")]
        public List<EthMinedBlock> MinedBlocks { get; set; }
    }
}