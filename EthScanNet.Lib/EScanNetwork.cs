// ReSharper disable IdentifierTypo

using System;

namespace EthScanNet.Lib
{
    public class EScanNetwork
    {
        public static readonly EScanNetwork MainNet = new("https://api.etherscan.io/api");
        [Obsolete("Will be replaced with MainNet and deprecated")]
        public static readonly EScanNetwork EScanMainNet = new("https://api.etherscan.io/api");
        public static readonly EScanNetwork RopstenNet = new("https://api-ropsten.etherscan.io/api");
        public static readonly EScanNetwork KovanNet = new("https://api-kovan.etherscan.io/api");
        public static readonly EScanNetwork RinkebyNet = new("https://api-rinkeby.etherscan.io/api");
        public static readonly EScanNetwork GoerliNet = new("https://api-goerli.etherscan.io/api");
        public static readonly EScanNetwork BscTestNet = new("https://api-testnet.bscscan.com/api", true);
        public static readonly EScanNetwork BscMainNet = new("https://api.bscscan.com/api", true);


        public bool IsBsc { get; }
        private readonly string _networkString;

        public EScanNetwork(string networkString)
        {
            this._networkString = networkString;
            this.IsBsc = false;
        }

        public EScanNetwork(string networkString, bool isBsc = false)
        {
            this._networkString = networkString;
            this.IsBsc = isBsc;
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