using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Contracts;
using EthScanNet.Lib.Models.EScan;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthScanNet.Lib.Models.ApiRequests.Contracts
{
    internal class EScanGetContractSourceCodeRequest : EScanRequest
    {
        public EScanAddress Address { get; set; }

        internal EScanGetContractSourceCodeRequest(EScanAddress address, EScanClient eScanClient)
            : base(eScanClient, typeof(EScanABIResponse), EScanModules.Contract, EScanActions.GetContractSourceCode)
        {
            this.Address = address;
        }
    }
}
