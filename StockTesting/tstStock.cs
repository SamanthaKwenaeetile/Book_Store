using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        private long tstBookID = 9780545010221;
        private string tstBookName = "Harry Potter and the Deathly Hallows";
        private Boolean tstInStock = true;
        private int tstNumberAvailable = 59;
        private DateTime tstReleaseDate = new DateTime(2007, 7, 21);

        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void BookIDOK()
        {
            clsStock AStock = new clsStock();
            long TestData = 9780545010221;
            AStock.BookID = TestData;
            Assert.AreEqual(AStock.BookID, TestData);
        }

        [TestMethod]
        public void BookNameOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "Harry Potter and the Deathly Hallows";
            AStock.BookName = TestData;
            Assert.AreEqual(AStock.BookName, TestData);
        }

        [TestMethod]
        public void InStockOK()
        {
            clsStock AStock = new clsStock();
            Boolean TestData = true;
            AStock.InStock = TestData;
            Assert.AreEqual(AStock.InStock, TestData);
        }

        [TestMethod]
        public void NumberAvailableOK()
        {
            clsStock AStock = new clsStock();
            int TestData = 59;
            AStock.NumberAvailable = TestData;
            Assert.AreEqual(AStock.NumberAvailable, TestData);
        }

        [TestMethod]
        public void releaseDateOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = new DateTime(2007, 7, 21);
            AStock.ReleaseDate = TestData;
            Assert.AreEqual(AStock.ReleaseDate, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            long BookID = 9780545010221;
            Found = AStock.Find(BookID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookIDNotFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            long BookID = 9780545010221;
            Found = AStock.Find(BookID);
            if (AStock.BookID != 9780545010221)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookNameNotFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            long BookID = 9780545010221;
            Found = AStock.Find(BookID);
            if (AStock.BookName != "Harry Potter and the Deathly Hallows")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockNotFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            long BookID = 9780545010221;
            Found = AStock.Find(BookID);
            if (AStock.InStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNumberAvailableNotFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            long BookID = 9780545010221;
            Found = AStock.Find(BookID);
            if (AStock.NumberAvailable != 59)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            long BookID = 9780545010221;
            Found = AStock.Find(BookID);
            if (AStock.ReleaseDate != Convert.ToDateTime("21/7/2007"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
