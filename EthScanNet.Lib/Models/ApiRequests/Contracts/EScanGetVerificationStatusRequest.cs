using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Contracts;

namespace EthScanNet.Lib.Models.ApiRequests.Contracts
{
    internal class EScanGetVerificationStatusRequest : EScanRequest
    {
        public string Guid { get; set; }

        internal EScanGetVerificationStatusRequest(string guid, EScanClient eScanClient)
            : base(eScanClient, typeof(EScanSourceCodeResponse), EScanModules.Contract, EScanActions.CheckCodeVerificationStatus)
        {
            this.Guid = guid;
        }
    }
}
