using System.Numerics;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts.Models
{
    public class EScanTokenTransferEvent
    {
        [JsonProperty("blockNumber")]
        public BigInteger BlockNumber { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("blockHash")]
        public string BlockHash { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("contractAddress")]
        public string ContractAddress { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("value")]
        public BigInteger Value { get; set; }

        [JsonProperty("tokenID")]
        public string TokenID { get; set; }

        [JsonProperty("tokenName")]
        public string TokenName { get; set; }

        [JsonProperty("tokenSymbol")]
        public string TokenSymbol { get; set; }

        [JsonProperty("tokenDecimal")]
        public string TokenDecimal { get; set; }

        [JsonProperty("transactionIndex")]
        public string TransactionIndex { get; set; }

        [JsonProperty("gas")]
        public BigInteger Gas { get; set; }

        [JsonProperty("gasPrice")]
        public BigInteger GasPrice { get; set; }

        [JsonProperty("gasUsed")]
        public BigInteger GasUsed { get; set; }

        [JsonProperty("cumulativeGasUsed")]
        public BigInteger CumulativeGasUsed { get; set; }

        [JsonProperty("input")]
        public string Input { get; set; }

        [JsonProperty("confirmations")]
        public BigInteger Confirmations { get; set; }
    }
}