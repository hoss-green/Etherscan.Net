using System;
using System.Net.Http;
using System.Threading.Tasks;
using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Extensions;
using EthScanNet.Lib.Models.ApiResponses;
using EthScanNet.Lib.Models.EScan;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EthScanNet.Lib.Models.ApiRequests
{
    internal class EScanRequest
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string Module { get; }

        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Action { get; }
        private Type _responseType;

        //public Type returnType { get; set; }
        internal EScanRequest(Type responseType, EScanModules module, EScanActions action)
        {
            if (responseType.BaseType != typeof(EScanResponse))
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
            string requestUrl = EScanClient.BaseUrl;
            string queryString = this.ToQueryString();
            string finalUrl = requestUrl + queryString + "&apiKey=" + EScanClient.ApiKeyToken;

            if (EScanClient.ThrottleMs.HasValue)
            {
                await Task.Delay(EScanClient.ThrottleMs.Value);
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
                EScanGenericResponse genericResponse = JsonConvert.DeserializeObject<EScanGenericResponse>(resultContent);
                if (genericResponse.Message.StartsWith("NotOk", StringComparison.OrdinalIgnoreCase))
                {
                    if (genericResponse.ResultMessage.GetType() != typeof(JArray))
                    {
                        throw new("Error with API result: (" + genericResponse.ResultMessage + ")");
                    }

                    throw new("Error with API result: (Unknown)");
                }

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