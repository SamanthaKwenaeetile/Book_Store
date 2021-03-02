using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //instance of a staff collection class is created
            clsStaffCollection AllRecords = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllRecords);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //instance of a staff collection class is created
            clsStaffCollection AllRecords = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data is a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 1;
            TestItem.FullName = "Rookaya Dokrat";
            TestItem.StaffPwd = "default!";
            TestItem.DateOfBirth = Convert.ToDateTime("15/12/1998");
            TestItem.Salary = 9.50M;
            TestItem.FullTime = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllRecords.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllRecords.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //instance of a staff collection class is created
            clsStaffCollection AllRecords = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffID = 1;
            TestStaff.FullName = "Rookaya Dokrat";
            TestStaff.StaffPwd = "default!";
            TestStaff.DateOfBirth = Convert.ToDateTime("15/12/1998");
            TestStaff.Salary = 9.50M;
            TestStaff.FullTime = false;
            //Assign the data to the property
            AllRecords.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllRecords.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //instance of a staff collection class is created
            clsStaffCollection AllRecords = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data is a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 1;
            TestItem.FullName = "Rookaya Dokrat";
            TestItem.StaffPwd = "default!";
            TestItem.DateOfBirth = Convert.ToDateTime("15/12/1998");
            TestItem.Salary = 9.50M;
            TestItem.FullTime = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllRecords.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllRecords.Count, TestList.Count);
        }

    }
}
