using EthScanNet.Lib.EthApi;

namespace EthScanNet.Lib
{
    public class EthScanClient
    {
        public static string ApiKeyToken { get; private set; }
        public static string BaseUrl { get; private set; }
        
        public static int? ThrottleMs { get; private set; }
        
        public Accounts Accounts { get; }
        public Tokens Tokens { get;  }
        public Stats Stats { get; }

        /// <summary>
        /// The base connection of the API, use this to access the features from within the account
        /// </summary>
        /// <param name="network">The ETH based EtherScan network to which to connect</param>
        /// <param name="apiKeyToken">The API key needed to be able to access more results</param>
        /// <param name="throttleMs">Delay between transaction requests, set to 200ms, as registered users are allowed 5/seconds</param>
        public EthScanClient(EthNetwork network, string apiKeyToken, int? throttleMs = 200)
        {
            ThrottleMs = throttleMs;
            BaseUrl = network;
            ApiKeyToken = apiKeyToken;
            this.Accounts = new();
            this.Tokens = new();
            this.Stats = new();
            
        }
        
        
    }
}