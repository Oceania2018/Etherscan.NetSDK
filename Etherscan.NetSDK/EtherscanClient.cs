using Etherscan.NetSDK.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etherscan.NetSDK
{
    public class EtherscanClient
    {
        private string apiKey { get; set; }

        public EtherscanClient(String apiKey)
        {
            this.apiKey = apiKey;
        }

        public RestRequest GetRestRequest(String module, String action)
        {
            var request = new RestRequest("/api");
            request.AddQueryParameter("module", module);
            request.AddQueryParameter("action", action);
            request.AddQueryParameter("apikey", apiKey);

            return request;
        }

        public T ExecuteAsGet<T>(RestRequest request)
        {
            var rest = new RestClient("http://api.etherscan.io");
            var response = rest.ExecuteAsGet<EtherscanResponse<T>>(request, "GET");

            return response.Data.Result;
        }
    }
}
