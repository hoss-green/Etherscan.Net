using System;
using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Tokens
{
    internal class EthTokenRequest : EScanRequest
    {
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public EScanAddress ContractAddress { get; }
        
        internal EthTokenRequest(EScanAddress contractAddress, EthModules module, EthActions action, Type returnType) : base(returnType, module, action)
        {
            this.ContractAddress = contractAddress;
        }
    }
}