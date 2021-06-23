namespace EthScanNet.Lib.EScanApi
{
    public abstract class BaseApi
    {
        protected EScanClient Client { get; private set; }

        public BaseApi(EScanClient client)
        {
            this.Client = client;
        }
        
        
    }
}