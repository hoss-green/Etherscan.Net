using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Extensions;
using EthScanNet.Lib.Models.EScan;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EthScanNet.Lib.Models.ApiRequests.Proxy
{
    internal class EScanProxyRequest : EScanRequest
    {
        
        internal EScanProxyRequest(EScanClient eScanClient, Type responseType, EScanActions action)
            : base(eScanClient, responseType, EScanModules.Proxy, action)
        {
        }

    }
}