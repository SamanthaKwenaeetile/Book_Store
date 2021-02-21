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

        public string Valid(string FirstName, string LastName, string DateOfBirth, string CustomerPwd)
        {
            String Error = "";
            DateTime DateTemp;
            if (FirstName.Length == 0)
            {
                Error = Error + "The first name can not be blank : ";
            }
            if (FirstName.Length > 30)
            {
                Error = Error + "The first name can not be more than 30 characters : ";
            }
            if (LastName.Length == 0)
            {
                Error = Error + "The last name can not be blank : ";
            }
            if (LastName.Length > 30)
            {
                Error = Error + "The last name can not be more than 30 characters : ";
            }
            if (CustomerPwd.Length == 0)
            {
                Error = Error + "The password can not be blank : ";
            }
            if (CustomerPwd.Length > 30)
            {
                Error = Error + "The password can not be more than 30 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(DateOfBirth);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannont be in the future : ";
                }
                if (DateTemp < DateTime.Now.Date.AddYears(-120))
                {
                    Error = Error + "The date cannot be set less than 120 years ago : ";
                }
            }
            catch
            {
                Error = Error + "The date was not valid : ";
            }
            return Error;
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