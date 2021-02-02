using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        private string tstFirstName = "Some first name"; 

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = tstFirstName;
            ACustomer.FirstName = TestData;
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Some last name";
            ACustomer.LastName = TestData;
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void ValidOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = tstFirstName;
            Error = ACustomer.valid(tstFirstName);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void MinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            Error = ACustomer.valid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = ACustomer.valid(TestData);
            Assert.AreNotEqual(Error, "");
        }

    }
}
