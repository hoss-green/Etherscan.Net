using System.Threading.Tasks;
using EthScanNet.Lib.Models.ApiRequests.Tokens;
using EthScanNet.Lib.Models.ApiResponses.Tokens;
using EthScanNet.Lib.Models.EthModels;

namespace EthScanNet.Lib.EthApi
{
    public sealed class Tokens
    {
     
        /// <summary>
        /// BscGetTokenTransferEvents getTokenTransferEvents = new(contractAddress);
        /// </summary>
        /// <param name="contractAddress"></param>
        /// <returns></returns>
        public async Task<EthApiTokenSupply> GetMaxSupply(EthAddress contractAddress)
        {
            EthGetMaxTokenSupply getMaxTokenSupply = new(contractAddress);
            return await getMaxTokenSupply.SendAsync();
        }
        
        /// <summary>
        /// Get BEP20-Token Circulating Supply (Applicable for Binance Cross Chain token Types) by ContractAddress
        /// </summary>
        /// <param name="contractAddress"></param>
        /// <returns></returns>
        public async Task<EthApiTokenSupply> GetCirculatingSupply(EthAddress contractAddress)
        {
            EthGetCirculatingTokenSupply getCirculatingTokenSupply = new(contractAddress);
            return await getCirculatingTokenSupply.SendAsync();
        }
    }
}