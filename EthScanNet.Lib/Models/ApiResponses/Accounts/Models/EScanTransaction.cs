using System.Numerics;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Accounts.Models
{
    public class EScanTransaction
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

        [JsonProperty("transactionIndex")]
        public string TransactionIndex { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("value")]
        public BigInteger Value { get; set; }

        [JsonProperty("gas")]
        public BigInteger Gas { get; set; }

        [JsonProperty("gasPrice")]
        public BigInteger GasPrice { get; set; }

        [JsonProperty("isError")]
        public string IsError { get; set; }

        [JsonProperty("txreceipt_status")]
        public string TxreceiptStatus { get; set; }

        [JsonProperty("input")]
        public string Input { get; set; }

        [JsonProperty("contractAddress")]
        public string ContractAddress { get; set; }

        [JsonProperty("cumulativeGasUsed")]
        public BigInteger CumulativeGasUsed { get; set; }

        [JsonProperty("gasUsed")]
        public string GasUsed { get; set; }

        [JsonProperty("confirmations")]
        public string Confirmations { get; set; }
    }
}