﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
            //Capture the full name
            Record.FullName = txtFullName.Text;
            //Capture the password
            Record.StaffPwd = txtStaffPwd.Text;
            //Capture the salary
            Record.Salary = decimal.Parse(txtSalary.Text);
            //Capture the date of birth
            Record.DateOfBirth = Convert.ToDateTime(txtDOB.Text);
            //Store the record in a session object
            Session["Record"] = Record;
            //navigate to the viewer page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        clsStaff Record = new clsStaff();
        Int32 StaffID;
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        Found = Record.Find(StaffID);

        if (Found == true)
        {
            txtFullName.Text = Record.FullName;
            txtSalary.Text = Record.Salary.ToString("N2"); //Rounds up 
            txtDOB.Text = Record.DateOfBirth.ToString();
            txtStaffPwd.Text = Record.StaffPwd;

        }
    }
}






