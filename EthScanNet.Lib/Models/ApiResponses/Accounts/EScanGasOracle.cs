using EthScanNet.Lib.Models.ApiResponses.Accounts.Models;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts
{
    public class EScanGasOracle : EScanResponse
    {
        [JsonProperty("result")]
        public EScanGasPrices GasPrices { get; set; }
    }
}