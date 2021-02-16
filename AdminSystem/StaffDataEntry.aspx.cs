using System;
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
        clsStaff Record = new clsStaff();
        Record.StaffID = int.Parse(txtStaffID.Text);
        Record.FullName = txtFullName.Text;
        Record.StaffPwd = txtStaffPwd.Text;
        Record.Salary = decimal.Parse(txtSalary.Text);
        //Record.DateOfBirth = txtDOB.Text.ToString();
        //Record.FullTime = Convert.ToBoolean(chkFullTime.Text);

        Session["Record"] = Record;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
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






