using DotNetToolkit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etherscan.NetSDK.Models
{
    public class EtherscanTransaction
    {
        public int TimeStamp { get; set; }

        /// <summary>
        /// Convert unix TimeStamp to DateTime
        /// </summary>
        public DateTime DateTime
        {
            get
            {
                return DateTimeHelper.FromUnixTime(TimeStamp);
            }
        }

        // TxHash
        public String Hash { get; set; }

        public String From { get; set; }

        public String To { get; set; }

        public Decimal Value { get; set; }

        /// <summary>
        /// Convert Value to 1 ETH
        /// </summary>
        public Decimal Amount
        {
            get
            {
                return Value / 1000000000000000000;
            }
        }

        /// <summary>
        /// 0 - No error
        /// </summary>
        public int IsError { get; set; }

        /// <summary>
        /// 1 = Success
        /// </summary>
        public int TxreceiptStatus { get; set; }
    }
}
