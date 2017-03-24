using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;

namespace CasinoTests
{
    [TestClass]
    public class BinBuilderTest
    {
        Bin<Outcome> bin;
        Outcome outcome0;
        Outcome outcome1;
        Outcome outcome2;
        Outcome outcome3;
        Outcome outcome4;
        Wheel wheel;
        BinBuilder binBuilder;

        [TestInitialize]
        public void TestInitialize()
        {
            wheel = new Wheel();
            binBuilder = new BinBuilder();
        }

        [TestMethod]
        public void GenerateStraightBetsTest()
        {
            outcome0 = new Outcome("0", 35);
            outcome1 = new Outcome("3", 35);
            outcome2 = new Outcome("8", 35);
            outcome3 = new Outcome("21", 35);
            outcome4 = new Outcome("00", 35);
            
            binBuilder.GenerateStraightBets(wheel);

            bin = wheel.Get(0);
            Assert.IsTrue(bin.Contains(outcome0));

            bin = wheel.Get(3);
            Assert.IsTrue(bin.Contains(outcome1));

            bin = wheel.Get(8);
            Assert.IsTrue(bin.Contains(outcome2));

            bin = wheel.Get(21);
            Assert.IsTrue(bin.Contains(outcome3));

            bin = wheel.Get(00);
            Assert.IsTrue(bin.Contains(outcome4));
        }

        [TestMethod]
        public void GenerateSplitBetsTest()
        {
            outcome0 = new Outcome("1, 2", 17);
            outcome1 = new Outcome("9, 12", 17);
            outcome2 = new Outcome("16, 19", 17);
            outcome3 = new Outcome("26, 29", 17);
            outcome4 = new Outcome("35, 36", 17);

            binBuilder.GenerateSplitBets(wheel);

            bin = wheel.Get(1);
            Assert.IsTrue(bin.Contains(outcome0));

            bin = wheel.Get(2);
            Assert.IsTrue(bin.Contains(outcome0));

            bin = wheel.Get(9);
            Assert.IsTrue(bin.Contains(outcome1));

            bin = wheel.Get(12);
            Assert.IsTrue(bin.Contains(outcome1));

            bin = wheel.Get(16);
            Assert.IsTrue(bin.Contains(outcome2));

            bin = wheel.Get(19);
            Assert.IsTrue(bin.Contains(outcome2));

            bin = wheel.Get(26);
            Assert.IsTrue(bin.Contains(outcome3));

            bin = wheel.Get(29);
            Assert.IsTrue(bin.Contains(outcome3));

            bin = wheel.Get(35);
            Assert.IsTrue(bin.Contains(outcome4));

            bin = wheel.Get(36);
            Assert.IsTrue(bin.Contains(outcome4));
        }

        [TestMethod]
        public void GenerateStreetBetsTest()
        {
            outcome0 = new Outcome("1, 2, 3", 11);
            outcome1 = new Outcome("16, 17, 18", 11);
            outcome2 = new Outcome("34, 35, 36", 11);

            binBuilder.GenerateStreetBets(wheel);

            bin = wheel.Get(1);
            Assert.IsTrue(bin.Contains(outcome0));

            bin = wheel.Get(2);
            Assert.IsTrue(bin.Contains(outcome0));

            bin = wheel.Get(3);
            Assert.IsTrue(bin.Contains(outcome0));

            bin = wheel.Get(16);
            Assert.IsTrue(bin.Contains(outcome1));

            bin = wheel.Get(17);
            Assert.IsTrue(bin.Contains(outcome1));

            bin = wheel.Get(18);
            Assert.IsTrue(bin.Contains(outcome1));

            bin = wheel.Get(34);
            Assert.IsTrue(bin.Contains(outcome2));

            bin = wheel.Get(35);
            Assert.IsTrue(bin.Contains(outcome2));

            bin = wheel.Get(36);
            Assert.IsTrue(bin.Contains(outcome2));
        }

        [TestMethod]
        public void GenerateCornerBetsTest()
        {
            outcome0 = new Outcome("1, 2, 4, 5", 8);
            outcome1 = new Outcome("20, 21, 23, 24", 8);
            outcome2 = new Outcome("32, 33, 35, 36", 8);

            binBuilder.GenerateCornerBets(wheel);

            bin = wheel.Get(1);
            Assert.IsTrue(bin.Contains(outcome0));

            bin = wheel.Get(2);
            Assert.IsTrue(bin.Contains(outcome0));

            bin = wheel.Get(4);
            Assert.IsTrue(bin.Contains(outcome0));

            bin = wheel.Get(5);
            Assert.IsTrue(bin.Contains(outcome0));

            bin = wheel.Get(20);
            Assert.IsTrue(bin.Contains(outcome1));

            bin = wheel.Get(21);
            Assert.IsTrue(bin.Contains(outcome1));

            bin = wheel.Get(23);
            Assert.IsTrue(bin.Contains(outcome1));

            bin = wheel.Get(24);
            Assert.IsTrue(bin.Contains(outcome1));

            bin = wheel.Get(32);
            Assert.IsTrue(bin.Contains(outcome2));

            bin = wheel.Get(33);
            Assert.IsTrue(bin.Contains(outcome2));

            bin = wheel.Get(35);
            Assert.IsTrue(bin.Contains(outcome2));

            bin = wheel.Get(36);
            Assert.IsTrue(bin.Contains(outcome2));
        }

        [TestMethod]
        public void GenerateLineBetsTest()
        {
        }

        [TestMethod]
        public void GenerateDozenBetsTest()
        {
        }

        [TestMethod]
        public void GenerateColumnBetsTest()
        {
        }

        [TestMethod]
        public void GenerateEvenMoneyBetsTest()
        {
        }

        [TestMethod]
        public void GenerateZeroBetsTest()
        {
        }
    }
}
