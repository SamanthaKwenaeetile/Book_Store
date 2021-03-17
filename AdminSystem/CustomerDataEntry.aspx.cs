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
        clsCustomer ACustomer = new clsCustomer();
        String FirstName = txtFirstName.Text;
        String LastName = txtLastName.Text;
        String DateOfBirth = txtDateOfBirth.Text;
        String CustomerPwd = txtCustomerPwd.Text;
        String Error = "";
        Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, CustomerPwd);
        if (Error == "")
        {
            ACustomer.FirstName = FirstName;
            ACustomer.LastName = LastName;
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            ACustomer.CustomerPwd = CustomerPwd;
            ACustomer.ActiveAcc = chkActiveAcc.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = ACustomer;
            CustomerList.Add();
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
}