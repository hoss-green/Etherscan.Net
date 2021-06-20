// ReSharper disable IdentifierTypo
namespace EthScanNet.Lib
{
    public class EScanNetwork
    {
        public static readonly EScanNetwork EScanMainNet = new("https://api.etherscan.io/api");
        public static readonly EScanNetwork RopstenNet = new("https://api-ropsten.etherscan.io/api");
        public static readonly EScanNetwork KovanNet = new("https://api-kovan.etherscan.io/api");
        public static readonly EScanNetwork RinkebyNet = new("https://api-rinkeby.etherscan.io/api");
        public static readonly EScanNetwork GoerliNet = new("https://api-goerli.etherscan.io/api");
        public static readonly EScanNetwork BscTestNet = new("https://api-testnet.bscscan.com/api");
        public static readonly EScanNetwork BscMainNet = new("https://api.bscscan.com/api");
        
        private readonly string _networkString;
        
        private EScanNetwork(string networkString)
        {
            this._networkString = networkString;
        }

        public override string ToString()
        {
            return this._networkString;
        }

        public static implicit operator string(EScanNetwork network)
        {
            return network._networkString;
        }
    }
}