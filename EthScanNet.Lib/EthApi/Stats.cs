using System.Threading.Tasks;
using EthScanNet.Lib.Models.ApiRequests.Stats;
using EthScanNet.Lib.Models.ApiResponses.Tokens;

namespace EthScanNet.Lib.EthApi
{
    public sealed class Stats
    {
     
        /// <summary>
        /// Get Total Supply of BNB on the Binance Smart Chain
        /// </summary>
        /// <returns></returns>
        public async Task<EthApiTokenSupply> GetTotalSupply()
        {
            EthGetTotalBnbSupply getTotalBnbSupply = new();
            //BscGetMaxTokenSupply getMaxTokenSupply = new();
            return await getTotalBnbSupply.SendAsync();
        }
    }
}