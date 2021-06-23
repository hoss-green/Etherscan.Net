using System.Threading.Tasks;
using EthScanNet.Lib.Models.ApiRequests.EthGasTracker;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EScanDateTime = EthScanNet.Lib.Models.EScan.EScanDateTime;

namespace EthScanNet.Lib.EScanApi
{
    public class EthGasTracker : BaseApi
    {
        public EthGasTracker(EScanClient client) : base(client)
        {
            
        }

        /// <summary>
        /// BscGetTokenTransferEvents getTokenTransferEvents = new(contractAddress);
        /// </summary>
        /// <param name="gasPrice">Gas price, in Wei</param>
        /// <returns>Result returned in seconds, gasprice value in Wei</returns>
        public async Task<EScanDateTime> GetEstimatedConfirmationTime(long gasPrice = 2000000000)
        {
            EScanGetEstimatedConfirmationTime getEstimatedConfirmationTime = new(gasPrice, this.Client);
            return await getEstimatedConfirmationTime.SendAsync();
        }
        
        /// <summary>
        /// BscGetTokenTransferEvents getTokenTransferEvents = new(contractAddress);
        /// </summary>
        /// <param name="gasPrice">Gas price, in Wei</param>
        /// <returns>Result returned in seconds, gasprice value in Wei</returns>
        public async Task<EScanGasOracle> GetGasOracle()
        {
            EScanGetGasOracle getGasOracle = new(this.Client);
            return await getGasOracle.SendAsync();
        }
    }
}