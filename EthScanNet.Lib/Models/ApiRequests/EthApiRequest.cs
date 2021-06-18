using System;
using System.Net.Http;
using System.Threading.Tasks;
using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Extensions;
using EthScanNet.Lib.Models.ApiResponses;
using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiRequests
{
    internal class EthApiRequest
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string Module { get; }
        
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Action { get; }
        private Type _responseType;

        //public Type returnType { get; set; }
        internal EthApiRequest(Type responseType, EthModules module, EthActions action)
        {
            if (responseType.BaseType != typeof(EthApiResponse))
            {
                const string type = "response type should inherit from 'BscResponse'";
                throw new(type);
            }

            this._responseType = responseType;
            this.Module = module.ToString();
            this.Action = action.ToString();
        }

        internal async Task<dynamic> SendAsync()
        {
            HttpClient client = new HttpClient();
            string requestUrl = EthScanClient.BaseUrl;
            string queryString = this.ToQueryString();
            string finalUrl = requestUrl + queryString + "&apiKey=" + EthScanClient.ApiKeyToken;

            if (EthScanClient.ThrottleMs.HasValue)
            {
                await Task.Delay(EthScanClient.ThrottleMs.Value);
            }
            
            HttpRequestMessage requestMessage = new(HttpMethod.Get, finalUrl);
            try
            {
                HttpResponseMessage result = await client.SendAsync(requestMessage);
                if (!result.IsSuccessStatusCode)
                {
                    throw new HttpRequestException("Server issue (" + result.StatusCode + "): " + result.ReasonPhrase);
                }

                string resultContent = await result.Content.ReadAsStringAsync();
                dynamic responseObject = JsonConvert.DeserializeObject(resultContent, this._responseType);
                return responseObject;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}