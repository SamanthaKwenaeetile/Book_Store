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
        Record.FullName = txtFullName.Text;
        Record.StaffPwd = txtStaffPwd.Text;
        Record.Salary = double.Parse(txtSalary.Text);
        /*Record.DateOfBirth = Convert.ToDateTime(txtDOB);
        Record.FullTime = Convert.ToBoolean(chkFullTime);*/

        Session["Record"] = Record;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }



    
}