using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        private string tstFirstName = "Bruno";
        private string tstLastName = "da Silva Ribeiro";
        private string tstCustomerPwd = "eRRor!2";
        private long tstContactNumber = 7543466733;

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
        public void FirstNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "b";
            Error = ACustomer.FirstNameValid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            Error = ACustomer.FirstNameValid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(30, '*');
            Error = ACustomer.FirstNameValid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = ACustomer.FirstNameValid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(500, '*');
            Error = ACustomer.FirstNameValid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = tstLastName;
            ACustomer.LastName = TestData;
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void LastNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "b";
            Error = ACustomer.LastNameValid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            Error = ACustomer.LastNameValid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(30, '*');
            Error = ACustomer.LastNameValid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = ACustomer.LastNameValid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(500, '*');
            Error = ACustomer.LastNameValid(TestData);
            Assert.AreNotEqual(Error, "");
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
            Int64 TestData = tstContactNumber;
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

        [TestMethod]
        public void CustomerPwdMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "qwerty";
            Error = ACustomer.CustomerPwdValid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPwdMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            Error = ACustomer.CustomerPwdValid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPwdMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(15, '*');
            Error = ACustomer.CustomerPwdValid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPwdMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = ACustomer.CustomerPwdValid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPwdExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(500, '*');
            Error = ACustomer.CustomerPwdValid(TestData);
            Assert.AreNotEqual(Error, "");
        }


    }
}
