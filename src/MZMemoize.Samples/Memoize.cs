using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MZMemoize.Samples
{
    [TestClass]
    public class Memoize
    {
        static Func<int, int, string> funcConcat = FuncEx.Create((int x, int y) => {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            return String.Format("{0} of {1}", x, y);
        })
        .Memoize(threadSafe: true);

        [TestMethod]
        public void Memoized()
        {
            // 1. Place breakpoints at line 10, 20, 22, 24.
            // 2. In Visual Studio debug this test method.
            // 3. Note breakpoints 20, 10 are hit. But after line 22 breakpoint 10 is skipped. This is because return value is cached.
            funcConcat(7, 9);
            // 4. Memoized cached on call into funcConcat due to execution at line 20.
            funcConcat(7, 9);
            // 5. This call is not cached and Func will be executed
            funcConcat(1, 2);
            // 6. The Thread.Sleep() inside the Memoized func indicates how this may be leveraged as a performance feature.
        }
    }
}
