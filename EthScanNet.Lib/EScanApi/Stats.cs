using System.Threading.Tasks;
using EthScanNet.Lib.Models.ApiRequests.Stats;
using EthScanNet.Lib.Models.ApiResponses.Stats;

namespace EthScanNet.Lib.EScanApi
{
    //TODO: Need to redo this using interfaces for clarity and ease
    public sealed class Stats
    {
        public BnbSpecific BscScan { get; }
        public EthSpecific EtherScan { get; }
        
        public Stats()
        {
            this.BscScan = new();
            this.EtherScan = new();
        }

        public sealed class BnbSpecific
        {
            /// <summary>
            /// Get Total Supply of BNB on the Binance Smart Chain
            /// </summary>
            /// <returns></returns>
            public async Task<EScanTotalCoinSupply> GetTotalSupply()
            {
                EScanGetTotalBscCoinSupply getTotalBscCoinSupply = new();
                return await getTotalBscCoinSupply.SendAsync();
            }    
        }

        public sealed class EthSpecific
        {
            /// <summary>
            /// Get Total Supply of BNB on the Binance Smart Chain
            /// </summary>
            /// <returns></returns>
            public async Task<EScanTotalCoinSupply> GetTotalSupply()
            {
                EScanGetTotalEthCoinSupply getTotalBscCoinSupply = new();
                return await getTotalBscCoinSupply.SendAsync();
            }    
        }
    }
}