using System;
using Bet_and_Get;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tesing
{
    [TestClass]
    public class UnitTest1
    {
        public void TestMethod1()
        {
            Form1 obj = new Form1();
            obj.resetAll();
            Assert.IsTrue(true);
        }
       

       
    }
}
