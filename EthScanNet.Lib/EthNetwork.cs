// ReSharper disable IdentifierTypo
namespace EthScanNet.Lib
{
    public class EthNetwork
    {
        public static readonly EthNetwork EthMainNet = new("https://api.etherscan.io/api");
        public static readonly EthNetwork RopstenNet = new("https://api-ropsten.etherscan.io/api");
        public static readonly EthNetwork KovanNet = new("https://api-kovan.etherscan.io/api");
        public static readonly EthNetwork RinkebyNet = new("https://api-rinkeby.etherscan.io/api");
        public static readonly EthNetwork GoerliNet = new("https://api-goerli.etherscan.io/api");
        public static readonly EthNetwork BscTestNet = new("https://api-testnet.bscscan.com/api");
        public static readonly EthNetwork BscMainNet = new("https://api.bscscan.com/api");
        
        private readonly string _networkString;
        
        private EthNetwork(string networkString)
        {
            this._networkString = networkString;
        }

        public override string ToString()
        {
            return this._networkString;
        }

        public static implicit operator string(EthNetwork network)
        {
            return network._networkString;
        }
    }
}