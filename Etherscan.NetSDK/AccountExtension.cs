using Etherscan.NetSDK.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etherscan.NetSDK
{
    public static class AccountExtension
    {
        public static decimal GetAccountBalance(this EtherscanClient etherscan, params String[] addresses)
        {
            var request = etherscan.GetRestRequest("account", addresses.Length > 1 ? "balancemulti" : "balance");
            request.AddQueryParameter("address", String.Join(',', addresses));
            request.AddQueryParameter("tag", "latest");

            return etherscan.ExecuteAsGet<Decimal>(request);
        }
    }
}
