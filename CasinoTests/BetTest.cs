using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;

namespace CasinoTests
{
    [TestClass]
    public class BetTest
    {
        Bet bet;
        Outcome outcome;

        [TestInitialize]
        public void TestInitialize()
        {
            outcome = new Outcome("Test", 3);
            bet = new Bet(25, outcome);
        }

        [TestMethod]
        public void BetConstructor()
        {
            Assert.AreEqual(bet.amountBet, 25);
            Assert.AreEqual(bet.outcome, outcome);
        }

        [TestMethod]
        public void BetWinAmount()
        {
            int amount = bet.WinAmount();

            Assert.AreEqual(amount, 100);
        }

        [TestMethod]
        public void BetLoseAmount()
        {
            int amount = bet.LoseAmount();

            Assert.AreEqual(amount, 25);
        }

        [TestMethod]
        public void BetToString()
        {
            Assert.AreEqual(bet.ToString(), "25 on Test (3:1)");
        }
    }
}
