using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;
using System;

// Note: Fake outcome values used
// Tests are likely to be invalid when proper generation of outcomes are created

namespace CasinoTests
{
    [TestClass]
    public class WheelTest
    {
        Wheel wheel;
        Bin<Outcome> bin0;
        Bin<Outcome> bin1;
        Bin<Outcome> bin9;
        Bin<Outcome> bin4;
        Outcome outcome0;
        Outcome outcome1;
        Outcome outcome2;
        Outcome outcome3;
        Outcome outcome4;
        Outcome outcome5;
        Outcome outcome6;
        Outcome outcome7;
        Outcome outcome8;
        Outcome outcome9;

        [TestInitialize]
        public void TestInitialize()
        {
            wheel = new Wheel();

            outcome0 = new Outcome("0", 35);
            outcome1 = new Outcome("1", 35);
            outcome2 = new Outcome("2", 35);
            outcome3 = new Outcome("3", 35);
            outcome4 = new Outcome("4", 35);
            outcome5 = new Outcome("5", 35);
            outcome6 = new Outcome("6", 35);
            outcome7 = new Outcome("7", 35);
            outcome8 = new Outcome("8", 35);
            outcome9 = new Outcome("9", 35);

            wheel.AddOutcome(0, outcome0);
            wheel.AddOutcome(0, outcome1);
            wheel.AddOutcome(0, outcome2);
            wheel.AddOutcome(0, outcome3);

            wheel.AddOutcome(1, outcome4);
            wheel.AddOutcome(1, outcome5);
            wheel.AddOutcome(1, outcome6);
            wheel.AddOutcome(1, outcome7);
            wheel.AddOutcome(1, outcome8);
            wheel.AddOutcome(1, outcome9);

            wheel.AddOutcome(9, outcome0);
            wheel.AddOutcome(9, outcome1);
            wheel.AddOutcome(9, outcome2);

            wheel.AddOutcome(4, outcome3);
            wheel.AddOutcome(4, outcome4);
            wheel.AddOutcome(4, outcome5);
            wheel.AddOutcome(4, outcome6);
            wheel.AddOutcome(4, outcome7);
        }

        [TestMethod]
        public void WheelConstructor()
        {
            Assert.IsTrue(wheel.rng != null);
            Assert.AreEqual(wheel.bins.Count, 38);
        }

        [TestMethod]
        public void WheelAddOutcome()
        {
            bin0 = wheel.Get(0);

            int count = bin0.Count;

            wheel.AddOutcome(0, outcome4);
            wheel.AddOutcome(0, outcome5);
            wheel.AddOutcome(0, outcome6);

            Assert.AreEqual(bin0.Count, count + 3);
        }

        [TestMethod]
        public void WheelNext()
        {
            wheel.rng = new Random(1);

            // Sequence with this seed and Next(38) is: 9, 4

            bin9 = wheel.Next();
            bin4 = wheel.Next();

            Assert.IsTrue(bin9.Contains(outcome0));
            Assert.IsTrue(bin9.Contains(outcome1));
            Assert.IsTrue(bin9.Contains(outcome2));

            Assert.IsTrue(bin4.Contains(outcome3));
            Assert.IsTrue(bin4.Contains(outcome4));
            Assert.IsTrue(bin4.Contains(outcome5));
            Assert.IsTrue(bin4.Contains(outcome6));
            Assert.IsTrue(bin4.Contains(outcome7));
        }

        [TestMethod]
        public void WheelGet()
        {
            bin0 = wheel.Get(0);
            bin1 = wheel.Get(1);

            Assert.AreEqual(bin0.Count, 4);
            Assert.AreEqual(bin1.Count, 6);
        }
    }
}
