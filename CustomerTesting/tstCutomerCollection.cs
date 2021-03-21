using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create new instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ActiveAcc = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPwd = "eRRor!2";
            TestItem.FirstName = "Bruno";
            TestItem.LastName = "Ribeiro";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test the values
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

       
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.ActiveAcc = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerPwd = "eRRor!2";
            TestCustomer.FirstName = "Bruno";
            TestCustomer.LastName = "Ribeiro";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.ActiveAcc = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPwd = "eRRor!2";
            TestItem.FirstName = "Bruno";
            TestItem.LastName = "Ribeiro";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.ActiveAcc = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPwd = "eRRor!2";
            TestItem.FirstName = "Bruno";
            TestItem.LastName = "Ribeiro";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            TestItem.ActiveAcc = false;
            TestItem.CustomerID = 2;
            TestItem.CustomerPwd = "eRRor!3";
            TestItem.FirstName = "Andre";
            TestItem.LastName = "Silva";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.ActiveAcc = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPwd = "eRRor!2";
            TestItem.FirstName = "Bruno";
            TestItem.LastName = "Ribeiro";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.ActiveAcc = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPwd = "eRRor!2";
            TestItem.FirstName = "Bruno";
            TestItem.LastName = "Ribeiro";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByLastName("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByLastNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByLastName("asdasdasdqweqw");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }


        [TestMethod]
        public void ReportByLastNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByLastName("asdzxczxzxqw");
            if(FilteredCustomers.Count == 2)
            {
                if(FilteredCustomers.CustomerList[0].CustomerID != 36)
                {
                    OK = false;
                }
                if(FilteredCustomers.CustomerList[0].CustomerID != 37)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
            }
            Assert.IsTrue(OK);
        }


    }
}