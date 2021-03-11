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
        public void ThisRecordPropertyOK()
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
            AllRecords.ThisRecord = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllRecords.ThisRecord, TestStaff);
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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllRecords = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 1;
            TestItem.FullName = "Rookaya Dokrat";
            TestItem.StaffPwd = "default!";
            TestItem.DateOfBirth = Convert.ToDateTime("15/12/1998");
            TestItem.Salary = 9.50M;
            TestItem.FullTime = false;
            //Set ThisRecord to the test data
            AllRecords.ThisRecord = TestItem;
            //Add the record
            PrimaryKey = AllRecords.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllRecords.ThisRecord.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllRecords.ThisRecord, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllRecords = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FullName = "Rookaya Dokrat";
            TestItem.StaffPwd = "default!";
            TestItem.DateOfBirth = Convert.ToDateTime("15/12/1998");
            TestItem.Salary = 9.50M;
            TestItem.FullTime = false;
            //Set ThisRecord to the test data
            AllRecords.ThisRecord = TestItem;
            //Add the record
            PrimaryKey = AllRecords.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test data
            TestItem.FullName = "Kaya Dokrat";
            TestItem.StaffPwd = "newDefault!";
            TestItem.DateOfBirth = Convert.ToDateTime("15/12/1998");
            TestItem.Salary = 12.30M;
            TestItem.FullTime = true;
            //set the record based on the new test data
            AllRecords.ThisRecord = TestItem;
            //update the record
            AllRecords.Update();
            //find the record
            AllRecords.ThisRecord.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllRecords.ThisRecord, TestItem);

        }

    }
}
