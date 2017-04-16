using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;

namespace CasinoTests
{
    [TestClass]
    public class TableTest
    {
        Table table;
        Bet bet1;
        Bet bet2;
        Bet bet3;
        Bet bet4;
        Outcome outcome;

        [TestInitialize]
        public void TestInitialize()
        {
            table = new Table();
            table.limit = 100;
            table.minimum = 5;
            outcome = new Outcome("test", 2);
            bet1 = new Bet(25, outcome);
            bet2 = new Bet(25, outcome);
            bet3 = new Bet(120, outcome);
            bet4 = new Bet(1, outcome);
            
            table.PlaceBet(bet1);
            table.PlaceBet(bet2);
        }

        [TestMethod]
        public void TablePlaceBet()
        {
            Assert.IsTrue(table.bets.Contains(bet1));
            Assert.IsTrue(table.bets.Contains(bet2));
            Assert.IsTrue(table.bets.Count == 2);
        }

        [TestMethod]
        public void TableGetEnumerator()
        {
            int count = 0;

            // uses GetEnumerator()
            foreach (Bet foundBet in table)
            {
                count++;
            }

            Assert.AreEqual(count, table.bets.Count);
        }

        [TestMethod]
        public void TableToString()
        {
            Assert.AreEqual(table.ToString(), "[25 on test (2:1), 25 on test (2:1)]");
        }

        [TestMethod]
        public void TableIsValid()
        {
            table.IsValid();

            table.PlaceBet(bet3);

            try
            {
                table.IsValid();
                Assert.Fail();
            }
            catch(Exception ex)
            {
                Assert.AreEqual(ex.GetType(), typeof(InvalidBet));
            }

            table.limit = 120;
            table.minimum = 25;

            table.IsValid();

            table.PlaceBet(bet4);

            try
            {
                table.IsValid();
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.GetType(), typeof(InvalidBet));
            }
        }
    }
}
