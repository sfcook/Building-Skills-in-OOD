using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;

namespace CasinoTests
{
    [TestClass]
    public class OutcomeTest
    {
        [TestMethod]
        public void OutcomeConstructor()
        {
            Outcome outcome = new Outcome("red", 1);

            Assert.AreEqual(outcome.name, "red");
            Assert.AreEqual(outcome.odds, 1);
        }
    }
}
