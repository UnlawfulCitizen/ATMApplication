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
            Assert.AreEqual(1860, atm.GetTotal());

        }
        [Test]
        public void WithdrawlINFError()
        {
            ATM atm = new ATM();
            atm.Withdrawl(208);
            atm.Withdrawl(9);
           
            Assert.AreEqual("Failure: insufficient funds", atm.Withdrawl(9));

        }
        [Test]
        public void CheckList()
        {
            ATM atm = new ATM();
            atm.Withdrawl(208);
            Assert.AreEqual(8, atm.List(100));

        }
    }
}