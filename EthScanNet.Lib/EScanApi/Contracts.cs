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
        public async Task<EScanABIResponse> GetABIAsync(EScanAddress address)
        {
            EScanGetContractABIRequest getAbi = new(address, this.Client);
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
    }
}
