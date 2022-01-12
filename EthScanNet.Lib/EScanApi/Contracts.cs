using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiRequests;
using EthScanNet.Lib.Models.ApiRequests.Contracts;
using EthScanNet.Lib.Models.ApiResponses.Contracts;
using EthScanNet.Lib.Models.EScan;

using System.Threading.Tasks;

namespace EthScanNet.Lib.EScanApi
{
    public sealed class Contracts : BaseApi
    {
        public Contracts(EScanClient client) : base(client)
        {
        }

        /// <summary>
        /// Get the Contract Application Binary Interface ( ABI ) of a verified smart contract.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<EScanAbiResponse> GetAbiAsync(EScanAddress address)
        {
            EScanGetContractAbiRequest getAbi = new(address, this.Client);
            return await getAbi.SendAsync();
        }

        /// <summary>
        /// Get Solidity source code of a verified smart contract.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<EScanSourceCodeResponse> GetSourceCodeAsync(EScanAddress address)
        {
            EScanGetContractSourceCodeRequest getSourceCode = new(address, this.Client);
            return await getSourceCode.SendAsync();
        }

        /// <summary>
        /// Check Source Code Verification Status.
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public async Task<EScanSourceCodeVerificationStatusResponse> GetSourceCodeVerificationStatusAsync(string guid)
        {
            EScanGetVerificationStatusRequest getStatus = new(guid, this.Client);
            return await getStatus.SendAsync();
        }

        /// <summary>
        /// Submit a contract source code to Etherscan for verification.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<EScanSourceCodeVerificationResponse> VerifySmartContractAsync(EScanContractCodeVerificationModel payload)
        {
            EScanRequest getSourceCode = new(this.Client, typeof(EScanSourceCodeVerificationResponse), EScanModules.Contract, EScanActions.VerifySourceCode);
            return await getSourceCode.SendAsync(payload);
        }

    }
}
