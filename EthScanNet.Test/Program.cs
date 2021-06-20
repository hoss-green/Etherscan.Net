using System;
using System.Threading.Tasks;
using EthScanNet.Lib;
using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.ApiResponses.Stats;
using EthScanNet.Lib.Models.ApiResponses.Tokens;
using EthScanNet.Lib.Models.EScan;

namespace EthScanNet.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApiCommands().Wait();
        }

        private static async Task RunApiCommands()
        {
            EScanClient client = new(EScanNetwork.BscTestNet, "YourApiKeyToken");
            //BscScanClient client = new BscScanClient(EthNetwork.MainNet, "YourApiKeyToken");

            try
            {
                await RunAccountCommandsAsync(client);
                await RunTokenCommandsAsync(client);
                await RunStatsCommandsAsync(client);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static async Task RunAccountCommandsAsync(EScanClient client)
        {
            Console.WriteLine("Account test started");
            EScanBalance apiBalance = await client.Accounts.GetBalanceAsync(new("0x0000000000000000000000000000000000001004"));
            EScanTransactions normalApiTransaction = await client.Accounts.GetNormalTransactionsAsync(new("0x0000000000000000000000000000000000001004"));
            EScanTransactions internalApiTransaction = await client.Accounts.GetInternalTransactionsAsync(new("0x0000000000000000000000000000000000001004"));
            EScanMinedBlocks apiMinedBlocks = await client.Accounts.GetMinedBlocksAsync(new("0x78f3adfc719c99674c072166708589033e2d9afe"));
            EScanTokenTransferEvents apiTokenTransferEvents = await client.Accounts.GetTokenEvents(new("0xf09f5e21f86692c614d2d7b47e3b9729dc1c436f"));
            Console.WriteLine("Account test complete");
        }
        
        private static async Task RunTokenCommandsAsync(EScanClient client)
        {
            EScanAddress contractAddress = new("0xf09f5e21f86692c614d2d7b47e3b9729dc1c436f");
            Console.WriteLine("Token test started");
            EScanTokenSupply apiTokenSupplyM = await client.Tokens.GetMaxSupply(contractAddress);
            EScanTokenSupply apiTokenSupplyC = await client.Tokens.GetCirculatingSupply(contractAddress);
            Console.WriteLine("Token test complete");
        }
    
        private static async Task RunStatsCommandsAsync(EScanClient client)
        {
            EScanAddress contractAddress = new("0xf09f5e21f86692c614d2d7b47e3b9729dc1c436f");
            Console.WriteLine("Stats test started");
            EScanTotalCoinSupply apiTokenSupplyBsc = await client.Stats.BscScan.GetTotalSupply();
            //EScanTotalCoinSupply apiTokenSupplyEth = await client.Stats.EtherScan.GetTotalSupply();
            Console.WriteLine("Stats test complete");
        }
        
    }
    
}
