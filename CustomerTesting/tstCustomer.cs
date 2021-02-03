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
        private string tstCustomerPwd = "eRRor!2";

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

        [TestMethod]
        public void ActiveOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.ActiveAcc = TestData;
            Assert.AreEqual(ACustomer.ActiveAcc, TestData);
        }


        [TestMethod]
        public void ContactNumberOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int64 TestData = 7543466733;
            ACustomer.ContactNumber = TestData;
            Assert.AreEqual(ACustomer.ContactNumber, TestData);
        }


        [TestMethod]
        public void CustomerPwdOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = tstCustomerPwd;
            ACustomer.CustomerPwd = TestData;
            Assert.AreEqual(ACustomer.CustomerPwd, TestData);
        }



    }
}
