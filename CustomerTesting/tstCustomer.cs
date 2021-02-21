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
        private DateTime tstDateOfBirth = DateTime.Now.Date.AddYears(-18);
        string DateOfBirth = DateTime.Now.Date.ToString();

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
            string tstFirstName = "bb";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstFirstName = "bbb";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstFirstName = "";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstFirstName = "";
            tstFirstName = tstFirstName.PadLeft(29, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstFirstName = "";
            tstFirstName = tstFirstName.PadLeft(30, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstFirstName = "qwertyuiopasdfg";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstFirstName = "";
            tstFirstName = tstFirstName.PadLeft(31, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstFirstName = "";
            tstFirstName = tstFirstName.PadLeft(500, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
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
            string tstLastName = "bb";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstLastName = "bbb";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstLastName = "";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstLastName = "";
            tstLastName = tstLastName.PadLeft(29, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstLastName = "";
            tstLastName = tstLastName.PadLeft(30, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstLastName = "qwertyuiopasdfg";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstLastName = "";
            tstLastName = tstLastName.PadLeft(31, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstLastName = "";
            tstLastName = tstLastName.PadLeft(500, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            Assert.IsTrue(Found);
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
            string tstCustomerPwd = "bb";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPwdMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstCustomerPwd = "bbb";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPwdMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstCustomerPwd = "";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPwdMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstCustomerPwd = "";
            tstCustomerPwd = tstCustomerPwd.PadLeft(29, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPwdMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstCustomerPwd = "";
            tstCustomerPwd = tstCustomerPwd.PadLeft(30, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPwdMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstCustomerPwd = "qwertyuiopasdfg";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPwdMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstCustomerPwd = "";
            tstCustomerPwd = tstCustomerPwd.PadLeft(31, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPwdExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string tstCustomerPwd = "";
            tstCustomerPwd = tstCustomerPwd.PadLeft(500, '*');
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            //TestData = "@CustomerID" ;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerID != CustomerID)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestFirstNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.FirstName != "Bruno" )
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.LastName != "Ribeiro")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerPwdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerPwd != "weqeqe23W")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = tstDateOfBirth;
            ACustomer.DateOfBirth = TestData;
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void DateOfBirthValidOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestData = tstDateOfBirth;
            Error = ACustomer.ValidDOB(tstDateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(+1);
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(+2);
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-120);
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            String DateOfBirth = "this is not a date";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            Error = ACustomer.Valid(tstFirstName, tstLastName, DateOfBirth, tstCustomerPwd);
            Assert.AreEqual(Error, "");
        }


    }
}
