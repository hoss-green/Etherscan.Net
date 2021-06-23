using System;
using System.Threading.Tasks;
using EthScanNet.Lib.Models.ApiRequests.Tokens;
using EthScanNet.Lib.Models.ApiResponses.Tokens;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.EScanApi
{
    public sealed class Tokens : BaseApi
    {
        public Tokens(EScanClient client) : base(client)
        {
        }

        /// <summary>
        /// BscGetTokenTransferEvents getTokenTransferEvents = new(contractAddress);
        /// </summary>
        /// <param name="contractAddress"></param>
        /// <returns></returns>
        public async Task<EScanTokenSupply> GetMaxSupply(EScanAddress contractAddress)
        {
            EScanGetMaxTokenSupply getMaxTokenSupply = new(contractAddress, this.Client);
            return await getMaxTokenSupply.SendAsync();
        }

        /// <summary>
        /// Get BEP20-Token Circulating Supply (Applicable for Binance Cross Chain token Types) by ContractAddress
        /// </summary>
        /// <param name="contractAddress">The address of the contract for the token</param>
        /// <returns></returns>
        public async Task<EScanTokenSupply> GetCirculatingSupply(EScanAddress contractAddress)
        {
            if (!this.Client.Network.IsBsc)
            {
                throw new Exception("Only for BSC based networks");
            }

            EScanGetCirculatingTokenSupply getCirculatingTokenSupply = new(contractAddress, this.Client);
            return await getCirculatingTokenSupply.SendAsync();
        }


    }
}