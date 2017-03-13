using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;

namespace CasinoTests
{
    [TestClass]
    public class OutcomeTest
    {
        Outcome outcome1;
        Outcome outcome2;
        Outcome outcome3;
        Outcome outcome4;

        [TestInitialize]
        public void TestInitialize()
        {
            outcome1 = new Outcome("Red", 1);
            outcome2 = new Outcome("Red", 2);
            outcome3 = new Outcome("Black", 1);
            outcome4 = new Outcome("00", 35);
        }

        [TestMethod]
        public void OutcomeConstructor()
        {
            Assert.AreEqual(outcome1.name, "Red");
            Assert.AreEqual(outcome1.odds, 1);
        }

        [TestMethod]
        public void OutcomeEquals()
        {
            Assert.AreEqual(outcome1, outcome2);
            Assert.AreNotEqual(outcome2, outcome3);
        }

        [TestMethod]
        public void OutcomeWinAmount()
        {
            Assert.AreEqual(outcome1.WinAmount(5), 5);
            Assert.AreEqual(outcome4.WinAmount(5), 175);

            Assert.AreEqual(outcome1.WinAmount(0), 0);
            Assert.AreEqual(outcome4.WinAmount(0), 0);

            Assert.AreEqual(outcome1.WinAmount(1), 1);
            Assert.AreEqual(outcome4.WinAmount(1), 35);
        }

        [TestMethod]
        public void OutcomeToString()
        {
            Assert.AreEqual(outcome1.ToString(), "Red (1:1)");
            Assert.AreEqual(outcome4.ToString(), "00 (35:1)");
        }

        [TestMethod]
        public void OutcomeGetHashCode()
        {
            Assert.AreEqual(outcome1.GetHashCode(), outcome2.GetHashCode());
            Assert.AreNotEqual(outcome1.GetHashCode(), outcome3.GetHashCode());
        }
    }
}
