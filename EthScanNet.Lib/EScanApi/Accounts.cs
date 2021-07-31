using System;
using System.Threading.Tasks;
using EthScanNet.Lib.Models.ApiRequests.Accounts;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.EScanApi
{
    public sealed class Accounts : BaseApi
    {
        public Accounts(EScanClient client) : base(client)
        {
        }

        /// <summary>
        /// Get the balance of a particular address
        /// </summary>
        /// <param name="address"></param>
        /// <returns>A Balance object</returns>
        public async Task<EScanBalance> GetBalanceAsync(EScanAddress address)
        {
            EScanGetAccountBalance apiGetAccountBalance = new(address, this.Client);
            return await apiGetAccountBalance.SendAsync();
        }

        /// <summary>
        /// Get a list of 'Normal' Transactions By Address
        /// </summary>
        /// <param name="address"></param>
        /// <param name="startBlock">Starting blockNo to retrieve results from</param>
        /// <param name="endBlock">ending blockNo to retrieve results from</param>
        /// <param name="page">the number of the page to return</param>
        /// <param name="offset">the maximum number of results per page to return</param>
        /// <returns>Returns up to a maximum of the last 10000 transactions only</returns>
        public async Task<EScanTransactions> GetNormalTransactionsAsync(
            EScanAddress address,
            ulong? startBlock = null,
            ulong? endBlock = null,
            int? page = null,
            int? offset = null)
        {
            EScanGetNormalTransactions getNormalTransactions = new(address, startBlock, endBlock, page, offset, this.Client);
            return await getNormalTransactions.SendAsync();
        }

        /// <summary>
        /// Get a list of 'Internal' Transactions by Address
        /// </summary>
        /// <param name="address"></param>
        /// <param name="startBlock">Starting blockNo to retrieve results from</param>
        /// <param name="endBlock">ending blockNo to retrieve results from</param>
        /// <param name="page">the number of the page to return</param>
        /// <param name="offset">the maximum number of results per page to return</param>
        /// <returns>Returns up to a maximum of the last 10000 transactions only</returns>
        public async Task<EScanTransactions> GetInternalTransactionsAsync(
            EScanAddress address,
            ulong? startBlock = null,
            ulong? endBlock = null,
            int? page = null,
            int? offset = null)
        {
            EScanGetInternalTransactionsByAddress getInternalTransactionsByAddress = new(address, startBlock, endBlock, page, offset, this.Client);
            return await getInternalTransactionsByAddress.SendAsync();
        }

        /// <summary>
        /// Get a list of 'Internal' Transactions by Transaction Hash
        /// </summary>
        /// <param name="txHash"></param>
        /// <returns>Returns up to a maximum of the last 10000 transactions only</returns>
        public async Task<EScanTransactions> GetInternalTransactionsAsync(string txHash)
        {
            EScanGetInternalTransactionsByHash getInternalTransactionsByAddress = new(txHash, this.Client);
            return await getInternalTransactionsByAddress.SendAsync();
        }
        
        /// <summary>
        /// Get a list of 'Internal' Transactions by Address
        /// </summary>
        /// <param name="address"></param>
        /// <param name="startBlock">Starting blockNo to retrieve results from</param>
        /// <param name="endBlock">ending blockNo to retrieve results from</param>
        /// <param name="page">the number of the page to return</param>
        /// <param name="offset">the maximum number of results per page to return</param>
        /// <returns>Returns up to a maximum of the last 10000 transactions only</returns>
        public async Task<EScanTransactions> GetInternalTransactionsByAddressAsync(
            EScanAddress address,
            ulong? startBlock = null,
            ulong? endBlock = null,
            int? page = null,
            int? offset = null)
        {
            EScanGetInternalTransactionsByAddress getInternalTransactionsByAddress = new(address, startBlock, endBlock, page, offset, this.Client);
            return await getInternalTransactionsByAddress.SendAsync();
        }


        /// <summary>
        /// Get a list of 'Internal' Transactions by Address
        /// </summary>
        /// <param name="txHash"></param>
        /// <returns>Returns up to a maximum of the last 10000 transactions only</returns>
        public async Task<EScanTransactions> GetInternalTransactionsByTxHashAsync(string txHash)
        {
            EScanGetInternalTransactionsByHash getInternalTransactionsByAddress = new(txHash, this.Client);
            return await getInternalTransactionsByAddress.SendAsync();
        }

        /// <summary>
        /// Get list of Blocks that have been Validated by Address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<EScanMinedBlocks> GetMinedBlocksAsync(EScanAddress address)
        {
            EScanGetMinedBlocks getMinedBlocks = new(address, this.Client);
            return await getMinedBlocks.SendAsync();
        }

        /// <summary>
        /// Get a list of "ERC721 - Token Transfer Events" by Address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<EScanTokenTransferEvents> GetTokenEvents(EScanAddress address)
        {
            EScanGetTokenTransferEvents getTokenTransferEvents = new(address, this.Client);
            return await getTokenTransferEvents.SendAsync();
        }

        public async Task<EScanTokenTransferEvents> GetTokenEvents(EScanAddress address, EScanAddress tokenAddress)
        {
            EScanGetTokenTransferEvents getTokenTransferEvents = new(address, this.Client);
            return await getTokenTransferEvents.SendAsync();
        }


        /// <summary>
        /// Get Token Account Balance for TokenContractAddress for a specific holder Address
        /// </summary>
        /// <param name="address">The account address that contains the token</param>
        /// <param name="contractAddress">The address of the contract for the token</param>
        /// <returns></returns>
        public async Task<EScanBalance> GetTokenBalanceForAddress(EScanAddress address, EScanAddress contractAddress)
        {
            EScanGetTokenBalanceForAccount getTokenBalanceForAccount = new(address, contractAddress, this.Client);
            return await getTokenBalanceForAccount.SendAsync();
        }
    }
}