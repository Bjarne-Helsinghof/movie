using System;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using movierating.Rating;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
         IRating r = new Rating();

        [TestMethod] //1
        public void TestGetNumberOfReviewsFromSelectUser()
        {

            Assert.IsTrue(r.GetNumberOfReviewsFromSelectUser(1) == 5);
            Assert.IsFalse(r.GetNumberOfReviewsFromSelectUser(1) == 10000);
        }

       
        [TestMethod] //2
        public void TestTrueGetAverageReviewRatingFromUser()
        {

            Assert.IsTrue(r.GetAverageReviewRatingFromUser(1) ==4.0);
        }
            

    }
}