using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MZMemoize.Samples
{
    [TestClass]
    public class FuncEx_Sample
    {
        [TestMethod]
        public void StringConcat_Func()
        {
            Func<int, int, string> funcConcat = (x, y) => 
                String.Format("{0} of {1}", x, y);
            Assert.AreEqual("7 of 9", funcConcat(7, 9));
        }

        [TestMethod]
        public void StringConcat_FuncEx()
        {
            var funcConcat = FuncEx.Create((int x, int y) =>
                String.Format("{0} of {1}", x, y));
            Assert.AreEqual("7 of 9", funcConcat(7, 9));
        }
    }
}
