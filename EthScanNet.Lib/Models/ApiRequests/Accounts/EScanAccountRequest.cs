using System;
using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EScanAccountRequest : EScanRequest
    {
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
        public EScanAddress Address { get; set; }
        
        internal EScanAccountRequest(EScanAddress address, EScanClient eScanClient,  EScanModules module, EScanActions action, Type returnType) : base(eScanClient, returnType, module, action)
        {
            this.Address = address;
        }
    }
}