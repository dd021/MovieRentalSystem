using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRentalSystem.Common;
using System;

namespace MovieRentTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckConnection()
        {
            DBOperation db = new DBOperation();
            Assert.AreEqual(db.CheckConnectionState(), true);
        }

        [TestMethod]
        public void CheckNumberValidation()
        {
            string number = "ABCD123456";
            Assert.AreEqual(Validation.IsNumber(number), false);

        }
    }
}
