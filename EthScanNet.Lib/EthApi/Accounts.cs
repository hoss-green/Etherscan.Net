using System.Threading.Tasks;
using EthScanNet.Lib.Models.ApiRequests.Accounts;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.EthApi
{
    public sealed class Accounts
    {
        /// <summary>
        /// Get the balance of a particular address
        /// </summary>
        /// <param name="address"></param>
        /// <returns>A Balance object</returns>
        public async Task<EScanBalance> GetBalanceAsync(EScanAddress address)
        {
            EScanGetAccountBalance apiGetAccountBalance = new(address);
            return await apiGetAccountBalance.SendAsync();
        }

        public async Task<EScanTransactions> GetNormalTransactionsAsync(EScanAddress address, ulong? startBlock = null, ulong? endBlock = null)
        {
            EScanGetNormalTransactions getNormalTransactions = new(address);
            return await getNormalTransactions.SendAsync();
        }
        
        /// <summary>
        /// Get a list of 'Internal' Transactions by Address
        /// </summary>
        /// <param name="address"></param>
        /// <param name="startBlock"></param>
        /// <param name="endBlock"></param>
        /// <returns></returns>
        public async Task<EScanTransactions> GetInternalTransactionsAsync(EScanAddress address, ulong? startBlock = null, ulong? endBlock = null)
        {
            EScanGetInternalTransactions getInternalTransactions = new(address);
            return await getInternalTransactions.SendAsync();
        }

        public async Task<EScanMinedBlocks> GetMinedBlocksAsync(EScanAddress address)
        {
            EScanGetMinedBlocks getMinedBlocks = new(address);
            return await getMinedBlocks.SendAsync();
        }
        
        /// <summary>
        /// Get a list of "ERC721 - Token Transfer Events" by Address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<EScanTokenTransferEvents> GetTokenEvents(EScanAddress address)
        {
            EScanGetTokenTransferEvents getTokenTransferEvents = new(address);
            return await getTokenTransferEvents.SendAsync();
        }
        
        public async Task<EScanTokenTransferEvents> GetTokenEvents(EScanAddress address, EScanAddress tokenAddress)
        {
            EScanGetTokenTransferEvents getTokenTransferEvents = new(address);
            return await getTokenTransferEvents.SendAsync();
        }
    }
}