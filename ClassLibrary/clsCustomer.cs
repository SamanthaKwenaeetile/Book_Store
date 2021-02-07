using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {

        }
        private string mFirstName;
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        private string mLastName;
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        private Boolean mActiveAcc;
        public bool ActiveAcc
        {
            get
            {
                return mActiveAcc;
            }
            set 
            {
                mActiveAcc = value;
            }
        }

        private long mContactNumber;
        public long ContactNumber
        {
            get
            {
                return mContactNumber;
            }
            set
            {
                mContactNumber = value;
            }
        }

        private string mCustomerPwd;
        public string CustomerPwd
        {
            get
            {
                return mCustomerPwd;
            }
            set
            {
                mCustomerPwd = value;
            }
        }

        private Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

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

        public bool Find(int CustomerID)
        {
            mCustomerID = CustomerID;
            mFirstName = "Bruno";
            mActiveAcc = true;
            mLastName = "Ribeiro";
            mContactNumber = 7543466733;
            mCustomerPwd = "Ribei32!ro";
            return true;
        }
    }
}