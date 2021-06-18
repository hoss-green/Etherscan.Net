using System;
using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.EthModels;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EthAccountRequest : EthApiRequest
    {
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public EthAddress Address { get; }
        
        internal EthAccountRequest(EthAddress address, EthModules module, EthActions action, Type returnType) : base(returnType, module, action)
        {
            this.Address = address;
        }
    }
}