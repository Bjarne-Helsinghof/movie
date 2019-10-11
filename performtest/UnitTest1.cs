using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using movierating.Rating;

namespace performtest
{
    [TestClass]
    public class UnitTest1
    {
        IRating r = new Rating();
        private double MTime = 4;
        [TestMethod]
        public void TestMethod1()
        {
            Stopwatch s = Stopwatch.StartNew();

            s.Stop();
            var seconds = s.ElapsedMilliseconds / 1000.00;
            Assert.IsTrue(seconds <= MTime);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Stopwatch s = Stopwatch.StartNew();

            
            s.Stop();
            var seconds = s.ElapsedMilliseconds / 1000.00;
            Assert.IsTrue(seconds <= MTime);
        }


    }
}
