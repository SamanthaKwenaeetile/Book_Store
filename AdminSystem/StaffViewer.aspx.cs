using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff Record = new clsStaff();
        Record = (clsStaff)Session["Record"];
        Response.Write(Record.FullName);
        Response.Write(Record.StaffPwd);
        Response.Write(Record.Salary);
        /*Response.Write(Record.DateOfBirth);
        Response.Write(Record.FullTime);*/
    }
}