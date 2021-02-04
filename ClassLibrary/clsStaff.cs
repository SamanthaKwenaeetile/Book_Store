using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffID { get; set; }
        public string FullName { get; set; }
        public string StaffPwd { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool FullTime { get; set; }
        public double Salary { get; set; }


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
    }


}