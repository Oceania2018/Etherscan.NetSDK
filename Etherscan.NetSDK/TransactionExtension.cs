using Etherscan.NetSDK.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etherscan.NetSDK
{
    public static class TransactionExtension
    {
        public static List<EtherscanTransaction> GetTransactions(this EtherscanClient etherscan, params String[] addresses)
        {
            if (addresses.Length == 0) return new List<EtherscanTransaction>();

            var request = etherscan.GetRestRequest("account", "txlist");
            request.AddQueryParameter("address", String.Join(',', addresses));
            request.AddQueryParameter("sort", "asc");

            return etherscan.ExecuteAsGet<List<EtherscanTransaction>>(request);
        }
    }
}
