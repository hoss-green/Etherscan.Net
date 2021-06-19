using System.Threading.Tasks;
using EthScanNet.Lib.Models.ApiRequests.Tokens;
using EthScanNet.Lib.Models.ApiResponses.Tokens;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.EthApi
{
    public sealed class Tokens
    {
     
        /// <summary>
        /// BscGetTokenTransferEvents getTokenTransferEvents = new(contractAddress);
        /// </summary>
        /// <param name="contractAddress"></param>
        /// <returns></returns>
        public async Task<EScanTokenSupply> GetMaxSupply(EScanAddress contractAddress)
        {
            EScanGetMaxTokenSupply getMaxTokenSupply = new(contractAddress);
            return await getMaxTokenSupply.SendAsync();
        }
        
        /// <summary>
        /// Get BEP20-Token Circulating Supply (Applicable for Binance Cross Chain token Types) by ContractAddress
        /// </summary>
        /// <param name="contractAddress"></param>
        /// <returns></returns>
        public async Task<EScanTokenSupply> GetCirculatingSupply(EScanAddress contractAddress)
        {
            EScanGetCirculatingTokenSupply getCirculatingTokenSupply = new(contractAddress);
            return await getCirculatingTokenSupply.SendAsync();
        }
    }
}