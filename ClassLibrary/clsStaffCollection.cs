using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblStaff_SelectALL");
            //get te count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff Record = new clsStaff();
                //read in the fields from the current record
                Record.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                Record.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                Record.StaffPwd = Convert.ToString(DB.DataTable.Rows[Index]["StaffPwd"]);
                Record.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                Record.FullTime = Convert.ToBoolean(DB.DataTable.Rows[Index]["FullTime"]);
                Record.Salary = Convert.ToDecimal(DB.DataTable.Rows[Index]["Salary"]);
                //add the record to the private data member
                mStaffList.Add(Record);
                //point at the next record
                Index++;
            }
        }

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //Staff List public property
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

   
        //public property for Count
        public int Count 
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //set the private data
                
            }
        }


        
        public clsStaff ThisStaff { get; set; }
    }
}