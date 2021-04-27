using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    //variable to store the primary key with page level scope
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the record to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayRecord();
            }

        }
    }

    private void DisplayRecord()
    {
        //create an instance of the staff collection
        clsStaffCollection RecordList = new clsStaffCollection();
        //find the record to update
        RecordList.ThisRecord.Find(StaffID);
        //display the data for this record
        txtStaffID.Text = RecordList.ThisRecord.StaffID.ToString();
        txtFullName.Text = RecordList.ThisRecord.FullName;
        txtStaffPwd.Text = RecordList.ThisRecord.StaffPwd;
        txtSalary.Text = RecordList.ThisRecord.Salary.ToString();
        txtDOB.Text = RecordList.ThisRecord.DateOfBirth.ToString();
        chkFullTime.Checked = RecordList.ThisRecord.FullTime;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //New instance of clsStaff
        clsStaff Record = new clsStaff();
        //Capture the full name
        string FullName = txtFullName.Text;
        //Capture the password
        string StaffPwd = txtStaffPwd.Text;
        //Capture the salary
        string Salary = txtSalary.Text;
        //Capture the date of birth
        string DateOfBirth = txtDOB.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = Record.Valid(FullName, StaffPwd, Salary, DateOfBirth);
        if (Error == "")
        {
            //Capture the staff id
            Record.StaffID = StaffID;
            //Capture the full name
            Record.FullName = FullName;
            //Capture the password
            Record.StaffPwd = StaffPwd;
            //Capture the salary
            Record.Salary = decimal.Parse(Salary);
            //Capture the date of birth
            Record.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //Capture FullTime
            Record.FullTime = chkFullTime.Checked;
            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. StaffID = -1 the add the data
            if (StaffID == -1)
            {
                //set the ThisRecord property
                StaffList.ThisRecord = Record;
                //add a new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisRecord.Find(StaffID);
                //set the ThisRecord property
                StaffList.ThisRecord = Record;
                //update the record
                StaffList.Update();
            }
            //navigate to the list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff Record = new clsStaff();
        //variable to store the primary key
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key of the user 
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = Record.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFullName.Text = Record.FullName;
            txtSalary.Text = Record.Salary.ToString("N2"); //Rounds up 
            txtDOB.Text = Record.DateOfBirth.ToString();
            txtStaffPwd.Text = Record.StaffPwd;

        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //navigate to the list page
        Response.Redirect("StaffList.aspx");
    }
}






