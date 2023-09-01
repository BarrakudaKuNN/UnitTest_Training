using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Training.Tests
{
    [TestClass()]
    public class First_TryTests
    {
        [TestMethod()]
        public void IsPrimeTest()
        {
            
            Assert.IsTrue(First_Try.IsPrime(2));
            Assert.IsTrue(First_Try.IsPrime(2));
            Assert.IsTrue(First_Try.IsPrime(2));
            Assert.IsTrue(First_Try.IsPrime(2));
            Assert.IsTrue(First_Try.IsPrime(24));
        }
    }
}