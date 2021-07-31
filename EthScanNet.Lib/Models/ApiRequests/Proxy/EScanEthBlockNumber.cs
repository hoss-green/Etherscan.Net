using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Extensions;
using EthScanNet.Lib.Models.ApiResponses.Proxy;
using EthScanNet.Lib.Models.EScan;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EthScanNet.Lib.Models.ApiRequests.Proxy
{
    internal class EScanEthBlockNumber : EScanRequest
    {
        
        internal EScanEthBlockNumber(EScanClient eScanClient)
            : base(eScanClient, typeof(EScanEthCurrentBlock), EScanModules.Proxy, EScanActions.EthBlockNumber)
        {
        }

    }
}