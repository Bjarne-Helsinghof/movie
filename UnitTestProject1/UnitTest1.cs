using System;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using movierating.Rating;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        readonly IRating _rating = new Rating();

        [TestMethod] //1
        public void TestTrueGetNumberOfReviewsFromSelectUser()
        {

            Assert.IsTrue(_rating.GetNumberOfReviewsFromSelectUser(1) == 3);
        }

        [TestMethod]
        public void TestFalseGetNumberOfReviewsFromSelectUser()
        {

            Assert.IsFalse(_rating.GetNumberOfReviewsFromSelectUser(1) == 10000);
        }
        [TestMethod] //2
        public void TestTrueGetAverageReviewRatingFromUser()
        {

            Assert.IsTrue(Math.Abs(_rating.GetAverageReviewRatingFromUser(1) - 4.0) < 5.1);
        }


    }
}