using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OddArrayTests
{
    [TestClass]
    public class UnitTest1
    {
        private int[] odd = {3,7,13,99,73};
        [TestMethod]
        public void CreateOddArray()
        {
            OddArray ODD = new OddArray(odd);
            Assert.IsNotNull(ODD);
        }
    }
}
