using System.Collections.Generic;
using EthScanNet.Lib.Models.ApiResponses.Accounts.Models;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts
{
    public class EthApiMinedBlocks : EthApiResponse
    {
        [JsonProperty("result")]
        public List<BscMinedBlock> MinedBlocks { get; set; }
    }
}