using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Contracts;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Contracts
{
    internal class EScanGetContractABIRequest : EScanRequest
    {
        public EScanAddress Address { get; set; }

        internal EScanGetContractABIRequest(EScanAddress address, EScanClient eScanClient) 
            : base(eScanClient, typeof(EScanABIResponse), EScanModules.Contract, EScanActions.GetContractABI)
        {
            this.Address = address;
        }
    }
}
