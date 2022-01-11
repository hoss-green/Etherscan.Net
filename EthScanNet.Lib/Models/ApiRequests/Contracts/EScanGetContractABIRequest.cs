using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Contracts;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Contracts
{
    internal class EScanGetContractAbiRequest : EScanRequest
    {
        public EScanAddress Address { get; set; }

        internal EScanGetContractAbiRequest(EScanAddress address, EScanClient eScanClient) 
            : base(eScanClient, typeof(EScanAbiResponse), EScanModules.Contract, EScanActions.GetContractAbi)
        {
            this.Address = address;
        }
    }
}
