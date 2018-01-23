using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Etherscan.NetSDK.UnitTest
{
    [TestClass]
    public class AccountTest : TestEssential
    {
        [TestMethod]
        public void BalanceTest()
        {
            var etherscan = new EtherscanClient(APIKEY);
            var amount = etherscan.GetAccountBalance(ADDRESS);
        }

        [TestMethod]
        public void TransactionTest()
        {
            var etherscan = new EtherscanClient(APIKEY);
            var transactions = etherscan.GetTransactions(ADDRESS);
        }
    }
}
