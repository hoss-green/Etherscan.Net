using System;
using EthScanNet.Lib.EScanApi;

namespace EthScanNet.Lib
{
    public class EScanClient
    {
        public static string ApiKeyToken { get; private set; }
        
        [Obsolete("Please use Client.Network.Url. Property will be deprecated in v2.")]
        public static string BaseUrl { get; private set; }
        
        public EScanNetwork Network { get; }

        public static int? ThrottleMs { get; private set; }
        
        public Accounts Accounts { get; }
        public Tokens Tokens { get;  }
        public Stats Stats { get; }
        
        public Proxy Proxy { get; }

        /// <summary>
        /// The base connection of the API, use this to access the features from within the account
        /// </summary>
        /// <param name="network">The ETH based EtherScan network to which to connect</param>
        /// <param name="apiKeyToken">The API key needed to be able to access more results</param>
        /// <param name="throttleMs">Delay between transaction requests, set to 200ms, as registered users are allowed 5/seconds</param>
        public EScanClient(EScanNetwork network, string apiKeyToken, int? throttleMs = 200)
        {
            ThrottleMs = throttleMs;
            BaseUrl = network;
            this.Network = network;
            ApiKeyToken = apiKeyToken;
            this.Accounts = new(this);
            this.Tokens = new(this);
            this.Stats = new(this);
            this.Proxy = new(this);

        }
        
        
    }
}