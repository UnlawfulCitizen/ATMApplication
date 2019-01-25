using NUnit.Framework;
using ATMApplication;
using System.Collections.Generic;

namespace Tests.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
          

        }

        [Test]
        public void CheckValueStarting()
        {
            ATM atm = new ATM();
            Dictionary<int, int> Bills = new Dictionary<int, int>();
            Bills = atm.Stock();
            Assert.AreEqual(1860, atm.TotalValue(Bills));
        }
        //[Test]
        //public void 
    }
}