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


        //private data member for thisRecord
        clsStaff mThisRecord = new clsStaff();
        //Staff List public property
        public clsStaff ThisRecord
        {
            get
            {
                //return the private data
                return mThisRecord;
            }
            set
            {
                //set the private data
                mThisRecord = value;
            }
        }


        public int Add()
        {
            //adds a new record to the database based on the values of thisRecord
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisRecord.FullName);
            DB.AddParameter("@StaffPwd", mThisRecord.StaffPwd);
            DB.AddParameter("@DateOfBirth", mThisRecord.DateOfBirth);
            DB.AddParameter("@Salary", mThisRecord.Salary);
            DB.AddParameter("@FullTime", mThisRecord.FullTime);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //updates an existing record to the database based on the values of thisRecord
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisRecord.StaffID);
            DB.AddParameter("@FullName", mThisRecord.FullName);
            DB.AddParameter("@StaffPwd", mThisRecord.StaffPwd);
            DB.AddParameter("@DateOfBirth", mThisRecord.DateOfBirth);
            DB.AddParameter("@Salary", mThisRecord.Salary);
            DB.AddParameter("@FullTime", mThisRecord.FullTime);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }
        
        public void Delete()
        {
            //deletes the record pointed to by thisRecird
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisRecord.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }
    }
}