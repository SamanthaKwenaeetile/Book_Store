using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID ;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if(IsPostBack == false)
        {
            if(CustomerID != 1)
            {
                DisplayCustomer();
            }
        }
    }

    private void DisplayCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerID);
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        chkActiveAcc.Checked = CustomerBook.ThisCustomer.ActiveAcc;
        txtCustomerPwd.Text = CustomerBook.ThisCustomer.CustomerPwd;
        txtDateOfBirth.Text = CustomerBook.ThisCustomer.DateOfBirth.ToString();
        txtFirstName.Text = CustomerBook.ThisCustomer.FirstName;
        txtLastName.Text = CustomerBook.ThisCustomer.LastName;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        String FirstName = txtFirstName.Text;
        String LastName = txtLastName.Text;
        String DateOfBirth = txtDateOfBirth.Text;
        String CustomerPwd = txtCustomerPwd.Text;
        String Error = "";
        Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, CustomerPwd);
        if (Error == "")
        {
            ACustomer.CustomerID = CustomerID;
            ACustomer.FirstName = FirstName;
            ACustomer.LastName = LastName;
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            ACustomer.CustomerPwd = CustomerPwd;
            ACustomer.ActiveAcc = chkActiveAcc.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            
            if(CustomerID == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = ACustomer.Find(CustomerID);

        if (Found == true)
        {
            txtFirstName.Text = ACustomer.FirstName;
            txtLastName.Text = ACustomer.LastName;
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();
            txtCustomerPwd.Text = ACustomer.CustomerPwd;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}