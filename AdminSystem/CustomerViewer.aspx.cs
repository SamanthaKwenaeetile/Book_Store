using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //Get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //Display the first name for this entry
        Response.Write(ACustomer.FirstName);
    }
}