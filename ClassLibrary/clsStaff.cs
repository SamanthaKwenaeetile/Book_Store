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

        private double mSalary;
        public double Salary
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

        public string ValidSalary(Double tstSalary)
        {
            if (tstSalary < 9.50 )
            {
                return "Salary cannot be less than £9.50 an hour";
            }
            if (tstSalary > 1000.00)
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
            mStaffID = 21;
            mFullName = "Rookaya Dokrat";
            mStaffPwd = "default!";
            mDateOfBirth = Convert.ToDateTime("15/12/1998");
            mFullTime = true;
            mSalary = 9.50;
            return true;
        }
    }


}