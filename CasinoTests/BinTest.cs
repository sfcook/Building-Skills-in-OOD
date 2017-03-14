using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;

namespace CasinoTests
{
    [TestClass]
    public class BinTest
    {
        Outcome outcome1;
        Outcome outcome2;
        Outcome outcome3;
        Outcome outcome4;
        Bin<Outcome> bin1;
        Bin<Outcome> bin2;

        [TestInitialize]
        public void TestInitialize()
        {
            outcome1 = new Outcome("Red", 1);
            outcome2 = new Outcome("Red", 2);
            outcome3 = new Outcome("Black", 1);
            outcome4 = new Outcome("00", 35);

            Outcome[] arrOutcomes1 = { outcome1, outcome2, outcome3 };
            Outcome[] arrOutcomes2 = { outcome1, outcome3, outcome4 };

            bin1 = new Bin<Outcome>(arrOutcomes1);
            bin2 = new Bin<Outcome>(arrOutcomes2);
        }

        [TestMethod]
        public void BinConstructor()
        {
            Assert.AreEqual(bin1.Count, 2);

            Assert.IsTrue(bin1.Contains(outcome1));
            Assert.IsTrue(bin1.Contains(outcome2));
            Assert.IsTrue(bin1.Contains(outcome3));

            Assert.AreEqual(bin2.Count, 3);

            Assert.IsTrue(bin2.Contains(outcome1));
            Assert.IsTrue(bin2.Contains(outcome3));
            Assert.IsTrue(bin2.Contains(outcome4));
        }
    }
}
