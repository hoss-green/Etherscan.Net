using System.Threading.Tasks;
using EthScanNet.Lib.Models.ApiRequests.Accounts;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EthModels;

namespace EthScanNet.Lib.EthApi
{
    public sealed class Accounts
    {
        /// <summary>
        /// Get the balance of a particular address
        /// </summary>
        /// <param name="address"></param>
        /// <returns>A Balance object</returns>
        public async Task<EthApiBalance> GetBalanceAsync(EthAddress address)
        {
            EthGetBnbAccountBalance apiGetBnbAccountBalance = new(address);
            return await apiGetBnbAccountBalance.SendAsync();
        }

        public async Task<EthApiTransactions> GetNormalTransactionsAsync(EthAddress address, ulong? startBlock = null, ulong? endBlock = null)
        {
            EthGetNormalTransactions getNormalTransactions = new(address);
            return await getNormalTransactions.SendAsync();
        }
        
        /// <summary>
        /// Get a list of 'Internal' Transactions by Address
        /// </summary>
        /// <param name="address"></param>
        /// <param name="startBlock"></param>
        /// <param name="endBlock"></param>
        /// <returns></returns>
        public async Task<EthApiTransactions> GetInternalTransactionsAsync(EthAddress address, ulong? startBlock = null, ulong? endBlock = null)
        {
            EthGetInternalTransactions getInternalTransactions = new(address);
            return await getInternalTransactions.SendAsync();
        }

        public async Task<EthApiMinedBlocks> GetMinedBlocksAsync(EthAddress address)
        {
            EthGetMinedBlocks getMinedBlocks = new(address);
            return await getMinedBlocks.SendAsync();
        }
        
        /// <summary>
        /// Get a list of "ERC721 - Token Transfer Events" by Address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<EthApiTokenTransferEvents> GetTokenEvents(EthAddress address)
        {
            EthGetTokenTransferEvents getTokenTransferEvents = new(address);
            return await getTokenTransferEvents.SendAsync();
        }
        
        public async Task<EthApiTokenTransferEvents> GetTokenEvents(EthAddress address, EthAddress tokenAddress)
        {
            EthGetTokenTransferEvents getTokenTransferEvents = new(address);
            return await getTokenTransferEvents.SendAsync();
        }
    }
}