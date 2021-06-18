using System;
using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.EthModels;

namespace EthScanNet.Lib.Models.ApiRequests.Tokens
{
    internal class EthTokenRequest : EthApiRequest
    {
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public EthAddress ContractAddress { get; }
        
        internal EthTokenRequest(EthAddress contractAddress, EthModules module, EthActions action, Type returnType) : base(returnType, module, action)
        {
            this.ContractAddress = contractAddress;
        }
    }
}