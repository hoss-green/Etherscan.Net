using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Contracts;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Lib.Models.ApiRequests.Contracts
{
    internal class EScanGetContractSourceCodeRequest : EScanRequest
    {
        public EScanAddress Address { get; set; }

        internal EScanGetContractSourceCodeRequest(EScanAddress address, EScanClient eScanClient)
            : base(eScanClient, typeof(EScanSourceCodeResponse), EScanModules.Contract, EScanActions.GetContractSourceCode)
        {
            this.Address = address;
        }
    }
}
