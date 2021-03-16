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

    //event handler for the add button
    protected void Button1_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstRecords.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstRecords.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else // if no record has been selected
        {
            //display an error
            lblError.Text = "Please Select A Record To Edit From The List";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var ro store the primary key value of the record to be deleted
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstRecords.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstRecords.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record has been selected 
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //Create instance of the staff collection
        clsStaffCollection Records = new clsStaffCollection();
        Records.ReportByFullName(txtFilter.Text);
        lstRecords.DataSource = Records.StaffList;
        //set the name of the primary key
        lstRecords.DataValueField = "StaffID";
        //set the name of the field to display
        lstRecords.DataTextField = "FullName";
        //bind the data to the list
        lstRecords.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //Create instance of the staff collection
        clsStaffCollection Records = new clsStaffCollection();
        Records.ReportByFullName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstRecords.DataSource = Records.StaffList;
        //set the name of the primary key
        lstRecords.DataValueField = "StaffID";
        //set the name of the field to display
        lstRecords.DataTextField = "FullName";
        //bind the data to the list
        lstRecords.DataBind();
    }
}