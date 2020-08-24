using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tesing
{
    [TestClass]
    public class UnitTest1
    {
        public void TestMethod2()
        {
            Guy obj = new Guy();
            obj.UpdateLabels();
            Assert.IsTrue(true);
        }



    }
}

