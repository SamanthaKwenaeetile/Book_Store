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




        public string ValidFullName(string tstFullName)
        {
            if (tstFullName.Length < 1)
            {
                return "Staff Name Cannot Be Blank";
            }
            if (tstFullName.Length > 50)
            {
                return "Staff Name Cannot Be More Than 50 Characters";
            }
            else
            {
                return "";
            }
        }

        public string ValidPwd(string tstStaffPwd)
        {
            if (tstStaffPwd.Length < 8)
            {
                return "Password Must Be 8 Characters Or More";
            }
            if (tstStaffPwd.Length > 50)
            {
                return "Password Cannot Be More Than 50 Characters";
            }
            else
            {
                return "";
            }
        }

        public string ValidSalary(decimal tstSalary)
        {
            if (tstSalary.CompareTo(9.50M) < 0)
            {
                return "Salary cannot be less than £9.50 an hour";
            }
            if (tstSalary.CompareTo(1000.00M) > 0)
            {
                return "Salary Cannot Be More Than £1000 an hour";
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
    }


}