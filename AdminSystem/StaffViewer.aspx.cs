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
        // Create new instance of clsStaff
        clsStaff Record = new clsStaff();
        //Get the data from the session object
        Record = (clsStaff)Session["Record"];
        //Display the full name for this entry
        Response.Write(Record.FullName);
        //Display the password for this entry
        Response.Write(Record.StaffPwd);
        //Display the salary for this entry
        Response.Write(Record.Salary);
        
        
    }
}