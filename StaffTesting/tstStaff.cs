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
        private string tstSalary = "9.50";
        private string tstDateOfBirth = DateTime.Now.Date.AddYears(-18).ToString();

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
        public void FullNameMinLessOne()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstFullName = ""; //This should trigger an error
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstFullName = "a"; //this should be okay
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstFullName = "aa"; //this should be okay
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstFullName = "";
            tstFullName = tstFullName.PadLeft(49, 'a'); //This should be okay
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstFullName = "";
            tstFullName = tstFullName.PadLeft(50, 'a'); //this should be okay
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstFullName = "";
            tstFullName = tstFullName.PadLeft(25, 'a'); //this should be okay
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstFullName = "";
            tstFullName = tstFullName.PadLeft(51, 'a'); //this should fail
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstFullName = "";
            tstFullName = tstFullName.PadLeft(500, 'a'); //this should fail
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
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
        public void StaffPwdMinLessOne()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstStaffPwd = "aaaaaaa"; //This should trigger an error
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPwdMin()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstStaffPwd = "aaaaaaaa"; //this should be okay
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SatffPwdMinPlusOne()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstStaffPwd = "aaaaaaaaa"; //this should be okay
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPwdMaxLessOne()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstStaffPwd = "";
            tstStaffPwd = tstStaffPwd.PadLeft(49, 'a'); //This should be okay
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPwdMax()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstStaffPwd = "";
            tstStaffPwd = tstStaffPwd.PadLeft(50, 'a'); //this should be okay
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPwdMid()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstStaffPwd = "";
            tstStaffPwd = tstStaffPwd.PadLeft(25, 'a'); //this should be okay
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPwdMaxPlusOne()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstStaffPwd = "";
            tstStaffPwd = tstStaffPwd.PadLeft(51, 'a'); //this should fail
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPwdExtremeMax()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //some test data is created to pass to the method
            string tstStaffPwd = "";
            tstStaffPwd = tstStaffPwd.PadLeft(500, 'a'); //this should fail
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }


        //DateOfBirth Tests
       [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsStaff Record = new clsStaff();
            DateTime TestData = DateTime.Now.Date.AddYears(-18);
            Record.DateOfBirth = TestData;
            Assert.AreEqual(Record.DateOfBirth, TestData);
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //create a variable to store the test data
            DateTime TestData;
            //set the date to today's date
            TestData = DateTime.Now.Date;
            //Change the date to whatever the date is less 100 years
            TestData = TestData.AddYears(-100);
            //convert the variable to a string variable
            string tstDateOfBirth = TestData.ToString();
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //create a variable to store the test data
            DateTime TestData;
            //set the date to today's date
            TestData = DateTime.Now.Date;
            //Change the date to whatever the date is less 18 years + a day which would be the day before an employee's 18th birthday
            TestData = TestData.AddYears(-18).AddDays(1);
            //convert the variable to a string variable
            string tstDateOfBirth = TestData.ToString();
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
           
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //create a variable to store the test data
            DateTime TestData;
            //set the date to today's date
            TestData = DateTime.Now.Date;
            //Change the date to whatever the date is less 100 years
            TestData = TestData.AddYears(-18);
            //convert the variable to a string variable
            string tstDateOfBirth = TestData.ToString();
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //create a variable to store the test data
            DateTime TestData;
            //set the date to today's date
            TestData = DateTime.Now.Date;
            //Change the date to whatever the date is less 18 and a day
            TestData = TestData.AddYears(-18).AddDays(-1);
            //convert the variable to a string variable
            string tstDateOfBirth = TestData.ToString();
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //create a variable to store the test data
            DateTime TestData;
            //set the date to today's date
            TestData = DateTime.Now.Date;
            //Change the date to whatever the date is plus 100 years
            TestData = TestData.AddYears(100);
            //convert the variable to a string variable
            string tstDateOfBirth = TestData.ToString();
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidValue()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //Set tstDateOfBirth to a non date value
            string tstDateOfBirth = "this is not a date";
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }



        //FullTime tests
        [TestMethod]
        public void FullTimePropertyOK()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            Boolean TestData = true;
            Record.FullTime = TestData;
            Assert.AreEqual(Record.FullTime, TestData);
        }


        //Salary Tests
        [TestMethod]
        public void SalaryPropertyOK()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            decimal TestData = 9.5M;
            Record.Salary = TestData;
            Assert.AreEqual(Record.Salary, TestData);
        }

        [TestMethod]
        public void SalaryExtremeMin()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //create a variable to store the test data
            string tstSalary = "-1000.00"; //this should fail
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinLessOne()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //create a variable to store the test data
            string tstSalary = "8.5"; //this should fail
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMin()
        {
            //instance of a staff class is created
            clsStaff Record = new clsStaff();
            //a string variable to store any error message
            string Error = "";
            //create a variable to store the test data
            string tstSalary = "9.5"; //this should pass
            //Invoke the method
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

         [TestMethod]
         public void SalaryMinPlusOne()
         {
             //instance of a staff class is created
             clsStaff Record = new clsStaff();
             //a string variable to store any error message
             string Error = "";
             //create a variable to store the test data
             string tstSalary = "10.5"; //this should pass
             //Invoke the method
             Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
             //Test to see if the result is correct
             Assert.AreEqual(Error, "");
         }

         [TestMethod]
         public void SalaryMaxMinusOne()
         {
             //instance of a staff class is created
             clsStaff Record = new clsStaff();
             //a string variable to store any error message
             string Error = "";
             //create a variable to store the test data
             string tstSalary = "999.00"; //this should pass
             //Invoke the method
             Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
             //Test to see if the result is correct
             Assert.AreEqual(Error, "");
         }

         [TestMethod]
         public void SalaryMax()
         {
             //instance of a staff class is created
             clsStaff Record = new clsStaff();
             //a string variable to store any error message
             string Error = "";
             //create a variable to store the test data
             string tstSalary = "1000.00"; //this should pass
             //Invoke the method
             Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
             //Test to see if the result is correct
             Assert.AreEqual(Error, "");
         }

         [TestMethod]
         public void SalaryMaxPlusOne()
         {
             //instance of a staff class is created
             clsStaff Record = new clsStaff();
             //a string variable to store any error message
             string Error = "";
             //create a variable to store the test data
             string tstSalary = "1001.00"; //this should fail
             //Invoke the method
             Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
             //Test to see if the result is correct
             Assert.AreNotEqual(Error, "");
         }

         [TestMethod]
         public void SalaryMaxExtreme()
         {
             //instance of a staff class is created
             clsStaff Record = new clsStaff();
             //a string variable to store any error message
             string Error = "";
             //create a variable to store the test data
             string tstSalary = "2000.00"; //this should fail
             //Invoke the method
             Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
             //Test to see if the result is correct
             Assert.AreNotEqual(Error, "");
         }

         [TestMethod]
         public void SalaryInvalidValue()
         {
             //instance of a staff class is created
             clsStaff Record = new clsStaff();
             //a string variable to store any error message
             string Error = "";
             //Set tstSalary to a non decimal value
             string tstSalary = "this is not a decimal";
             //Invoke the method
             Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
             //Test to see if the result is correct
             Assert.AreNotEqual(Error, "");
         } 

        //Find Method Test
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff Record = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 1;
            Found = Record.Find(StaffID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff Record = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = Record.Find(StaffID);
            if (Record.StaffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            clsStaff Record = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = Record.Find(StaffID);
            if (Record.FullName != "Rookaya Dokrat")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPwdFound()
        {
            clsStaff Record = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = Record.Find(StaffID);
            if (Record.StaffPwd != "default!")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFound()
        {
            clsStaff Record = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = Record.Find(StaffID);
            if (Record.DateOfBirth != Convert.ToDateTime("15/12/1998"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullTimeFound()
        {
            clsStaff Record = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = Record.Find(StaffID);
            if (Record.FullTime != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            clsStaff Record = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 21;
            Found = Record.Find(StaffID);
            if (Record.Salary.CompareTo(9.50M) == 0)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Validation Test
        [TestMethod]
        public void ValidMethodOK()
        {
            //A new instance of a class is created
            clsStaff Record = new clsStaff();
            //String variable is used to store any error message
            String Error = "";
            //Method is invoked
            Error = Record.Valid(tstFullName, tstStaffPwd, tstSalary, tstDateOfBirth);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
