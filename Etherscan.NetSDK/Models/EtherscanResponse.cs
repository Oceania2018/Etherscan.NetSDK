using System;
using System.Collections.Generic;
using System.Text;

namespace Etherscan.NetSDK.Models
{
    public class EtherscanResponse<T>
    {
        /// <summary>
        /// 1 - OK
        /// </summary>
        public int Status { get; set; }

        public String Message { get; set; }

        public T Result { get; set; }
    }
}
