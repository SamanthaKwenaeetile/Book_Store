using System;

namespace ClassLibrary
{
    public class clsStaff
    {
     
        //StaffID private member variable
        private Int32 mStaffID;
        //StaffID public property
        public Int32 StaffID
        {
            get
            {
                //return the private data
                return mStaffID;
            }
            set
            {
                //set the private data
                mStaffID = value;
            }
        }

        //FullName private member variable
        private string mFullName;
        //FullName public property
        public string FullName
        {
            get
            {
                //return the private data
                return mFullName;
            }
            set
            {
                //set the private data
                mFullName = value;
            }
        }

        //StaffPwd private member variable
        private string mStaffPwd;
        //StaffPwd public property
        public string StaffPwd
        {
            get
            {
                //return the private data
                return mStaffPwd;
            }
            set
            {
                //set the private data
                mStaffPwd = value;
            }
        }

        //DateOfBirth private member variable
        private DateTime mDateOfBirth;
        //DateOfBirth public property
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

        //FullTime private member variable
        private bool mFullTime;
        //FullTime public property
        public bool FullTime
        {
            get
            {
                //return the private data
                return mFullTime;
            }
            set
            {
                //set the private data
                mFullTime = value;
            }
        }

        //Salary private member variable
        private decimal mSalary;
        //Salary public property
        public decimal Salary
        {
            get
            {
                //return the private data
                return mSalary;
            }
            set
            {
                //set the private data
                mSalary = value;
            }
        }



        public bool Find(int staffID)
        {
            //instance of a data connection
            clsDataConnection DB = new clsDataConnection();
            //parameter for the staff id to search for
            DB.AddParameter("@StaffID", staffID);
            //execute stored procedure
            DB.Execute("spoc_tblStaff_FilterByStaffID");
            // check if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mStaffPwd = Convert.ToString(DB.DataTable.Rows[0]["StaffPwd"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mFullTime = Convert.ToBoolean(DB.DataTable.Rows[0]["FullTime"]);
                mSalary = Convert.ToDecimal(DB.DataTable.Rows[0]["Salary"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
            
            
        }

        public string Valid(string tstFullName, string tstStaffPwd, string tstSalary, string tstDateOfBirth)
        {
            //string variable that stores an error
            String Error = "";
            //A temporary variable to store dates
            DateTime DateTemp;
            //A temporary variable to store salary
            decimal SalaryTemp;

            //If the FullName is blank
            if (tstFullName.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Name may not be blank : ";
            }
            //if full name is greater than 50 characters
            if (tstFullName.Length > 50)
            {
                //record the error
                Error = Error + "Staff Name Cannot Be More Than 50 Characters : ";
            }

            //if the StaffPwd is less than 8 characrers
            if (tstStaffPwd.Length < 8)
            {
                //record the error
                Error = Error + "Password Must Be 8 Characters Or More : ";
            }
            //if the StaffPwd is more than 50 characters
            if (tstStaffPwd.Length > 50)
            {
                //record the error
                Error = Error + "Password Cannot Be More Than 50 Characters : ";
            }

            try
            {
                //copy the tstDateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(tstDateOfBirth);

                //Setting the minimum date of birth to 18 years ago and maximum age to 70 years ago
                DateTime minDOB = DateTime.Now.Date.AddYears(-18);
                DateTime maxDOB = DateTime.Now.Date.AddYears(-70);

                //If employee was born less than 18 years ago
                if (DateTemp > minDOB)
                {
                    //record the error
                    Error = Error + "Employee Is Under The Age of 18 :";
                }
                //If employee was born more than 70 years ago
                if (DateTemp < maxDOB)
                {
                    //record the error
                    Error = Error + "Employee Is Over The Age of 70 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }


            try
            {
                //copy the tstSalary value to the SalaryTemp variable
                SalaryTemp = Convert.ToDecimal(tstSalary);

                //If the employee's salary is less than £9.50 an hour
                if (SalaryTemp.CompareTo(9.50M) < 0)
                {
                    //record the error
                    Error = Error + "Salary cannot be less than £9.50 an hour : ";
                }
                //if the employee's salary is more than £1000.00 an hour
                if (SalaryTemp.CompareTo(1000.00M) > 0)
                {
                    //record the error
                    Error = Error + "Salary Cannot Be More Than £1000 an hour : ";
                }
                
            }
            catch
            {
                //record the error
                Error = Error + "The salary was not a valid salary : ";
            }

            //return any error message
            return Error;
        }
    }


}