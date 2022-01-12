
namespace EthScanNet.Lib.Models.ApiRequests.Contracts
{
    public class EScanContractCodeVerificationModel
    {
        /// <summary>
        /// Contract Address starts with 0x... 
        /// </summary>
        public string ContractAddress { get; set; }

        /// <summary>
        /// Contract Source Code (Flattened if necessary)
        /// </summary>
        public string SourceCode { get; set; }

        /// <summary>
        /// Solidity-single-file (default) or solidity-standard-json-input (for std-input-json-format support
        /// </summary>
        public string CodeFormat { get; set; }

        /// <summary>
        /// ContractName (if codeformat=solidity-standard-json-input, then enter contractname as ex: erc20.sol:erc20)
        /// </summary>
        public string ContractName { get; set; }

        /// <summary>
        /// See https://etherscan.io/solcversions for list of support versions
        /// </summary>
        public string CompilerVersion { get; set; }

        /// <summary>
        /// 0 = No Optimization, 1 = Optimization used (applicable when codeformat=solidity-single-file)
        /// </summary>
        public string OptimizationUsed { get; set; }

        /// <summary>
        /// Set to 200 as default unless otherwise  (applicable when codeformat=solidity-single-file)
        /// </summary>
        public string Runs { get; set; }

        /// <summary>
        /// If applicable
        /// </summary>
        public string ContstructorArguments { get; set; }

        /// <summary>
        /// Leave blank for compiler default, homestead, tangerineWhistle, spuriousDragon, byzantium,
        /// constantinople, petersburg, istanbul (applicable when codeformat=solidity-single-file)
        /// </summary>
        public string EvmVersion { get; set; }

        /// <summary>
        /// Valid codes 1-14 where 1=No License .. 14=Business Source License 1.1, see https://etherscan.io/contract-license-types
        /// </summary>
        public string LicenseType { get; set; }

        #region Libraries
        public string LibraryName1 { get; set; }
        public string LibraryAddress1 { get; set; }

        public string LibraryName2 { get; set; }
        public string LibraryAddress2 { get; set; }

        public string LibraryName3 { get; set; }
        public string LibraryAddress3 { get; set; }

        public string LibraryName4 { get; set; }
        public string LibraryAddress4 { get; set; }

        public string LibraryName5 { get; set; }
        public string LibraryAddress5 { get; set; }

        public string LibraryName6 { get; set; }
        public string LibraryAddress6 { get; set; }

        public string LibraryName7 { get; set; }
        public string LibraryAddress7 { get; set; }

        public string LibraryName8 { get; set; }
        public string LibraryAddress8 { get; set; }

        public string LibraryName9 { get; set; }
        public string LibraryAddress9 { get; set; }

        public string LibraryName10 { get; set; }
        public string LibraryAddress10 { get; set; }
        #endregion
    }
}
