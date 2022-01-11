using EthScanNet.Lib.Models.ApiResponses.Contracts.Models;

using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Contracts
{
    public class EScanSourceCodeResponse : EScanResponse
    {
        [JsonProperty("result")]
        public EScanContractSourceCode Contract { get; set; }

    }
}
