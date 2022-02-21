using System;
using System.Threading.Tasks;
using EthScanNet.Lib.Models.ApiRequests.Stats;
using EthScanNet.Lib.Models.ApiResponses.Stats;

namespace EthScanNet.Lib.EScanApi
{
    //TODO: Need to redo this using interfaces for clarity and ease
    public sealed class Stats : BaseApi
    {
        public BnbSpecific BscScan { get; }
        public EthSpecific EtherScan { get; }
        
        public Stats(EScanClient client) : base(client)
        {
            this.BscScan = new(client);
            this.EtherScan = new(client);
        }
 
        /// <summary>
        /// Get Total Supply of the token or coin on the current subscribed chain
        /// </summary>
        /// <returns></returns>
        public async Task<EScanTotalCoinSupply> GetTotalSupply()
        {
            if (this.Client.Network.IsBsc)
            {
                EScanGetTotalBscCoinSupply getTotalBscCoinSupply = new(this.Client);
                return await getTotalBscCoinSupply.SendAsync();
            }

            if (this.Client.Network.IsPolygon)
            {
                EScanGetTotalPolygonCoinSupply getTotalPolugonCoinSupply = new(this.Client);
                return await getTotalPolugonCoinSupply.SendAsync();
            }

            EScanGetTotalEthCoinSupply getTotalEthCoinSupply = new(this.Client);
            return await getTotalEthCoinSupply.SendAsync();
        }     
        
        [Obsolete("Use Stats.GetTotalSupply(). Class will be removed in v2")]
        public sealed class BnbSpecific : BaseApi
        {
            public BnbSpecific(EScanClient client) : base(client)
            {
            }
            
            /// <summary>
            /// Get Total Supply of BNB on the Binance Smart Chain
            /// </summary>
            /// <returns></returns>
            [Obsolete("Use Stats.GetTotalSupply(). Method will be removed in v2")]
            public async Task<EScanTotalCoinSupply> GetTotalSupply()
            {
                EScanGetTotalBscCoinSupply getTotalBscCoinSupply = new(this.Client);
                return await getTotalBscCoinSupply.SendAsync();
            }

           
        }

        [Obsolete("Use Stats.GetTotalSupply(). Class will be removed in v2")]
        public sealed class EthSpecific : BaseApi
        {
            public EthSpecific(EScanClient client) : base(client)
            {
            }            
            
            /// <summary>
            /// Get Total Supply of BNB on the Binance Smart Chain
            /// </summary>
            /// <returns></returns>
            [Obsolete("Use Stats.GetTotalSupply(). Method will be removed in v2")]
            public async Task<EScanTotalCoinSupply> GetTotalSupply()
            {
                EScanGetTotalEthCoinSupply getTotalEthCoinSupply = new(this.Client);
                return await getTotalEthCoinSupply.SendAsync();
            }

        }
    }
}