using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the BookID
        AStock.BookID = Convert.ToInt32(txtBookID.Text);
        //store the address in the session object
        Session["Astock"] = AStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        long BookID;
        Boolean Found = false;
        BookID = Convert.ToInt32(txtBookID.Text);
        Found = AStock.Find(BookID);
        if (Found == true)
        {
            txtBookName.Text = AStock.BookName;
            txtNumberAvailable.Text = Convert.ToString(AStock.NumberAvailable);
            txtReleaseDate.Text = Convert.ToString(AStock.ReleaseDate);
        }
    }
}