using EthScanNet.Lib;

using System;
using System.Threading.Tasks;

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
            string apiKey = null;

            //BscScanDemo demo = new(apiKey);
            EtherscanDemo demo = new EtherscanDemo(apiKey, EScanNetwork.RopstenNet);



            try
            {
                await demo.RunApiCommandsAsync();
                //await etherscanDemo.RunApiCommandsAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
    
}
