namespace EthScanNet.Lib.Enums
{
    // ReSharper disable once IdentifierTypo
    internal class EthActions
    {
        public static readonly EthActions Balance = new("Balance");
        public static readonly EthActions TxList = new("TxList");
        public static readonly EthActions TxListInternal = new( "TxListInternal");
        public static readonly EthActions TokenNftTx = new("TokenNftTx");
        public static readonly EthActions GetMinedBlocks = new( "GetMinedBlocks");
        public static readonly EthActions TokenSupply = new("TokenSupply");
        public static readonly EthActions TokenCSupply = new( "TokenCSupply");
        //public static readonly EthActions BnbSupply = new( "BnbSupply");

        public static class BncScanSpecific
        {
            public static readonly EthActions BnbSupply = new( "BnbSupply");
        }
        
        public static class EtherscanSpecific
        {
            public static readonly EthActions EthSupply = new( "EthSupply");
        }
        
        private readonly string _actionName;
        
        private EthActions(string networkString)
        {
            this._actionName = networkString;
        }

        public override string ToString()
        {
            return this._actionName;
        }

        public static implicit operator string(EthActions action)
        {
            return action._actionName;
        }
    }
    
    

    // internal enum EthActions
    // {
    //     Balance,
    //     TxList,
    //     TxListInternal,
    //     TokenNftTx,
    //     GetMinedBlocks,
    //     TokenSupply,
    //     TokenCSupply,
    //     BnbSupply
    // }
}