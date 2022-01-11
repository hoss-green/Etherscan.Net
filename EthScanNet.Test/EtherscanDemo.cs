using System;
using System.Threading.Tasks;
using EthScanNet.Lib;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.ApiResponses.Contracts;
using EthScanNet.Lib.Models.ApiResponses.Stats;
using EthScanNet.Lib.Models.ApiResponses.Tokens;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Test
{
    public class EtherscanDemo
    {
        private readonly string _apiKey;
        private readonly EScanNetwork _network;

        public EtherscanDemo(string apiKey, EScanNetwork network)
        {
            this._apiKey = apiKey ?? "YourApiKeyToken";
            this._network = network ?? EScanNetwork.MainNet;
        }

        public async Task RunApiCommandsAsync()
        {
            Console.WriteLine("Running EtherscanDemo with APIKey: " + this._apiKey);
            EScanClient client = new(this._network, this._apiKey);

            try
            {
                await RunAccountCommandsAsync(client);
                await RunTokenCommandsAsync(client);
                await RunStatsCommandsAsync(client);
                await RunContractCommandsAsync(client);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            
        }

        private async Task RunAccountCommandsAsync(EScanClient client)
        {
            Console.WriteLine("Account test started");
            EScanBalance apiBalance = await client.Accounts.GetBalanceAsync(new("0x0000000000000000000000000000000000001004"));
            Console.WriteLine("GetBalanceAsync: " +  apiBalance.Message);
            EScanTransactions normalApiTransaction = await client.Accounts.GetNormalTransactionsAsync(new("0x0000000000000000000000000000000000001004"));
            Console.WriteLine("GetNormalTransactionsAsync: " + normalApiTransaction.Message);
            EScanTransactions internalApiTransaction = await client.Accounts.GetInternalTransactionsAsync(new("0x0000000000000000000000000000000000001004"));
            Console.WriteLine("GetInternalTransactionsAsync: " + internalApiTransaction.Message);
            EScanMinedBlocks apiMinedBlocks = await client.Accounts.GetMinedBlocksAsync(new("0x78f3adfc719c99674c072166708589033e2d9afe"));
            Console.WriteLine("GetMinedBlocksAsync: " + apiMinedBlocks.Message);
            EScanTokenTransferEvents apiTokenTransferEvents = await client.Accounts.GetTokenEvents(new("0xf09f5e21f86692c614d2d7b47e3b9729dc1c436f"));
            Console.WriteLine("GetTokenEvents: " + apiTokenTransferEvents.Message);
            Console.WriteLine("Account test complete");
            EScanERC20TokenTransferEvents apiERC20TokenTransferEvents = await client.Accounts.GetERC20TokenEvents(new("0xf09f5e21f86692c614d2d7b47e3b9729dc1c436f"));
            Console.WriteLine("GetTokenEvents: " + apiTokenTransferEvents.Message);
            Console.WriteLine("Account test complete");
        }

        private async Task RunTokenCommandsAsync(EScanClient client)
        {
            EScanAddress holderAddress = new("0x2b7fc60fd13f32fed8730113a14e3468d2f17cdc");
            EScanAddress contractAddress = new("0xf7844cb890f4c339c497aeab599abdc3c874b67a");
            Console.WriteLine("Token test started");
            EScanTokenSupply apiTokenSupplyM = await client.Tokens.GetMaxSupply(contractAddress);
            Console.WriteLine("GetMaxSupply: " + apiTokenSupplyM.Message);
            EScanBalance balance = await client.Accounts.GetTokenBalanceForAddress(holderAddress, contractAddress);
            Console.WriteLine("GetTokenBalanceForAddress: " + balance.Message);
            Console.WriteLine("Token test complete");
        }

        private async Task RunStatsCommandsAsync(EScanClient client)
        {
            Console.WriteLine("Stats test started");
            EScanTotalCoinSupply totalSupply = await client.Stats.GetTotalSupply();
            Console.WriteLine("GetTotalSupply: " + totalSupply.Message);
            Console.WriteLine("Stats test complete");
        }

        private async Task RunContractCommandsAsync(EScanClient client)
        {
            Console.WriteLine("Contracts test started");

            EScanAddress contractAddress = new EScanAddress("0xBff53e93ad7F17028fa75F1AB6F5fdB18AD06e8a");
            EScanABIResponse abiResponse = await client.Contracts.GetABIAsync(contractAddress);
            Console.WriteLine("ABI: " + abiResponse.Message);

            EScanSourceCodeResponse sourceCodeResponse = await client.Contracts.GetSourceCodeAsync(contractAddress);
            Console.WriteLine("Source Code: " + sourceCodeResponse.Message);

            Console.WriteLine("Contracts test complete");
        }
    }
}