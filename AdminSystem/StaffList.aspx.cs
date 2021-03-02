using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayRecords();
        }
    }

    void DisplayRecords()
    {
        //Create instance of the staff collection
        clsStaffCollection Records = new clsStaffCollection();
        //set the data souce to the list of names in the collection
        lstRecords.DataSource = Records.StaffList;
        //set the name of the primary key
        lstRecords.DataValueField = "StaffID";
        //set the data field to display
        lstRecords.DataTextField = "FullName";
        //bind the data to the list
        lstRecords.DataBind();
    }
}