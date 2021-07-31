using System;
using System.Threading.Tasks;
using EthScanNet.Lib.Models.ApiRequests.Proxy;
using EthScanNet.Lib.Models.ApiRequests.Tokens;
using EthScanNet.Lib.Models.ApiResponses.Proxy;
using EthScanNet.Lib.Models.ApiResponses.Tokens;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.EScanApi
{
    public sealed class Proxy : BaseApi
    {
        public Proxy(EScanClient client) : base(client)
        {
        }
        
        public async Task<EScanEthCurrentBlock> CurrentBlock()
        {
            EScanEthBlockNumber ethBlockNumber = new(this.Client);
            return await ethBlockNumber.SendAsync();
        }
        


    }
}