using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool ActiveAcc { get; set; }
        public long ContactNumber { get; set; }
        public string CustomerPwd { get; set; }
        public string CustomerID { get; set; }

        public string valid(string tstFirstName)
        {
            if (tstFirstName.Length < 1)
            {
                return "First name cannot be blank";
            }
            if (tstFirstName.Length > 50)
            {
                return "First name cannot be more than 50";
            }
            else
            {
                return "";
            }
        }

        public string FirstNameValid(string testData)
        {
            if (testData.Length < 1)
            {
                return "Customer name cannot be empty";
            }
            if (testData.Length > 30)
            {
                return "Customer name cannot be longer that 30 characters";
            }
            else
            {
                return "";
            }
        }

        public string LastNameValid(string testData)
        {
            if (testData.Length < 1)
            {
                return "Customer name cannot be empty";
            }
            if (testData.Length > 30)
            {
                return "Customer name cannot be longer that 30 characters";
            }
            else
            {
                return "";
            }
        }

        public string CustomerPwdValid(string testData)
        {
            if (testData.Length < 6)
            {
                return "Customer password cannot be less than 6";
            }
            if (testData.Length > 15)
            {
                return "Customer password cannot be longer than 15 characters";
            }
            else
            {
                return "";
            }
        }
    }
}