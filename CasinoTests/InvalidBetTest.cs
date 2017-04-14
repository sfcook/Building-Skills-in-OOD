using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;

namespace CasinoTests
{
    [TestClass]
    public class InvalidBetTest
    {
        [TestMethod]
        public void InvalidBetException()
        {
            try
            {
                throw new InvalidBet();
            }
            catch(Exception ex)
            {
                Assert.AreEqual(ex.GetType(), typeof(InvalidBet));
            }
        }
    }
}
