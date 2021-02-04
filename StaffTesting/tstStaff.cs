﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //Good test data
        private string tstFullName = "Rookaya Dokrat";
        private string tstStaffPwd = "default!";
        private double tstSalary = 9.50;
        private DateTime tstDateOfBirth = DateTime.Now.Date.AddYears(-18);

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff Record = new clsStaff();
            Assert.IsNotNull(Record);
        }

        //StaffID Tests
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsStaff Record = new clsStaff();
            Int32 TestData = 1;
            Record.StaffID = TestData;
            Assert.AreEqual(Record.StaffID, TestData);
        }

        //Full Name tests
        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsStaff Record = new clsStaff();
            string TestData = tstFullName;
            Record.FullName = TestData;
            Assert.AreEqual(Record.FullName, TestData);
        }

        [TestMethod]
        public void FullNameValidOK()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = tstFullName;
            Error = Record.ValidFullName(tstFullName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = "a";
            Error = Record.ValidFullName(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinLessOne()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = "";
            Error = Record.ValidFullName(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(50, '*');
            Error = Record.ValidFullName(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = Record.ValidFullName(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(200, '*');
            Error = Record.ValidFullName(TestData);
            Assert.AreNotEqual(Error, "");
        }


        //StaffPwd Tests
        [TestMethod]
        public void StaffPwdPropertyOK()
        {
            clsStaff Record = new clsStaff();
            string TestData = tstStaffPwd;
            Record.StaffPwd = TestData;
            Assert.AreEqual(Record.StaffPwd, TestData);
        }

        [TestMethod]
        public void StaffPwdValidOK()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = tstStaffPwd;
            Error = Record.ValidPwd(tstStaffPwd);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPwdMin()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = tstStaffPwd;
            Error = Record.ValidPwd(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPwdMinLessOne()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = "0123456";
            Error = Record.ValidPwd(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPwdMax()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(50, '*');
            Error = Record.ValidPwd(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPwdMaxPlusOne()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = Record.ValidPwd(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPwdExtremeMax()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(200, '*');
            Error = Record.ValidPwd(TestData);
            Assert.AreNotEqual(Error, "");
        }


        //DateOfBirth Tests
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsStaff Record = new clsStaff();
            DateTime TestData = tstDateOfBirth;
            Record.DateOfBirth = TestData;
            Assert.AreEqual(Record.DateOfBirth, TestData);
        }

        [TestMethod]
        public void DateOfBirthValidOK()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            DateTime TestData = tstDateOfBirth;
            Error = Record.ValidDOB(tstDateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinMinusOne()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            DateTime TestData = tstDateOfBirth.AddYears(-1);
            Error = Record.ValidDOB(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            DateTime TestData = tstDateOfBirth.AddYears(1);
            Error = Record.ValidDOB(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            DateTime TestData = tstDateOfBirth.AddYears(200);
            Error = Record.ValidDOB(TestData);
            Assert.AreNotEqual(Error, "");
        }



        //FullTime tests
        [TestMethod]
        public void FullTimePropertyOK()
        {
            clsStaff Record = new clsStaff();
            Boolean TestData = true;
            Record.FullTime = TestData;
            Assert.AreEqual(Record.FullTime, TestData);
        }


        //Salary Tests
        [TestMethod]
        public void SalaryPropertyOK()
        {
            clsStaff Record = new clsStaff();
            Double TestData = tstSalary;
            Record.Salary = TestData;
            Assert.AreEqual(Record.Salary, TestData);
        }

        [TestMethod]
        public void SalaryValidOK()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            Double TestData = tstSalary;
            Error = Record.ValidSalary(tstSalary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryExtremeMin()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            Double TestData = -1000.00;
            Error = Record.ValidSalary(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinMinusOne()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            Double TestData = 8.50;
            Error = Record.ValidSalary(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxMinusOne()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            Double TestData = 9999.00;
            Error = Record.ValidSalary(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMax()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            Double TestData = 1000.00;
            Error = Record.ValidSalary(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            Double TestData = 1001.00;
            Error = Record.ValidSalary(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxExtreme()
        {
            clsStaff Record = new clsStaff();
            string Error = "";
            Double TestData = 2000.00;
            Error = Record.ValidSalary(TestData);
            Assert.AreNotEqual(Error, "");
        }
    }
}
