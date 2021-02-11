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

        private DateTime mDateOfBirth;

        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the private data
                mDateOfBirth = value;
            }
        }


        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            { 
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0] ["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mActiveAcc = Convert.ToBoolean(DB.DataTable.Rows[0]["ActiveAcc"]);
                mCustomerPwd = Convert.ToString(DB.DataTable.Rows[0]["CustomerPwd"]);
                return true;
             }
            else
            {
                return false;
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

        public string ValidDOB(DateTime tstDateOfBirth)
        {
            DateTime minDOB = DateTime.Now.Date.AddYears(-18);
            DateTime maxDOB = DateTime.Now.Date.AddYears(-70);

            if (tstDateOfBirth > minDOB)
            {
                return "Employee Is Under The Age of 18";
            }
            if (tstDateOfBirth < maxDOB)
            {
                return "Employee Is Over The Age of 70";
            }
            else
            {
                return "";
            }
        }


    }
}