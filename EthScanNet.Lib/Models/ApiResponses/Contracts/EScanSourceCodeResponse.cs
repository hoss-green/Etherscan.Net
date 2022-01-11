using EthScanNet.Lib.Models.ApiResponses.Contracts.Models;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace EthScanNet.Lib.Models.ApiResponses.Contracts
{
    public class EScanSourceCodeResponse : EScanResponse
    {
        [JsonProperty("result")]
        public List<EScanContractSourceCode> Contracts { get; set; }

    }
}
