using System;

namespace ClassLibrary
{
    public class clsStaff
    {
       
        private Int32 mStaffID;
        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }

        private string mFullName;
        public string FullName
        {
            get
            {
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }

        private string mStaffPwd;
        public string StaffPwd
        {
            get
            {
                return mStaffPwd;
            }
            set
            {
                mStaffPwd = value;
            }
        }

        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        private bool mFullTime;
        public bool FullTime
        {
            get
            {
                return mFullTime;
            }
            set
            {
                mFullTime = value;
            }
        }

        private decimal mSalary;
        public decimal Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
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
            // check if one record is found
            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mStaffPwd = Convert.ToString(DB.DataTable.Rows[0]["StaffPwd"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mFullTime = Convert.ToBoolean(DB.DataTable.Rows[0]["FullTime"]);
                mSalary = Convert.ToDecimal(DB.DataTable.Rows[0]["Salary"]);
                return true;
            }
            else
            {
                
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