namespace EthScanNet.Lib.Enums
{
    // ReSharper disable once IdentifierTypo
    internal class EScanActions
    {
        public static readonly EScanActions Balance = new("Balance");
        public static readonly EScanActions TxList = new("TxList");
        public static readonly EScanActions TxListInternal = new( "TxListInternal");
        public static readonly EScanActions TokenNftTx = new("TokenNftTx");
        public static readonly EScanActions GetMinedBlocks = new( "GetMinedBlocks");
        public static readonly EScanActions TokenSupply = new("TokenSupply");
        public static readonly EScanActions TokenCirculatingSupply = new( "TokenCSupply");
        public static readonly EScanActions TokenBalance = new( "TokenBalance");
        public static readonly EScanActions TxErc20Token = new("TokenTx");
        public static readonly EScanActions GetContractAbi = new("GetAbi");
        public static readonly EScanActions GetContractSourceCode = new("GetSourceCode");


        public static readonly EScanActions GasEstimate = new("GasEstimate");
        public static readonly EScanActions GasTracker = new("GasTracker");

        public static readonly EScanActions EthBlockNumber = new("Eth_BlockNumber");
        
        //public static readonly EthActions BnbSupply = new( "BnbSupply");

        public static class BncScanSpecific
        {
            public static readonly EScanActions BnbSupply = new( "BnbSupply");
        }
        
        public static class EtherscanSpecific
        {
            public static readonly EScanActions EthSupply = new( "EthSupply");
        }
        
        private readonly string _actionName;
        
        private EScanActions(string networkString)
        {
            this._actionName = networkString.ToLower();
        }

        public override string ToString()
        {
            return this._actionName;
        }

        public static implicit operator string(EScanActions action)
        {
            return action._actionName;
        }
    }
}