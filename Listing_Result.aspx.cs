using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Listing_Result : System.Web.UI.Page
{
    private int listingId;
    private string userName;
    private int carId;
    private string suggestedPrice;
    private string listingStatus;
    private string connectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        connectionString = ConfigurationManager.ConnectionStrings["database"].ToString();
        
    }
    
    private void filldata()
    {
        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da = new SqlDataAdapter("select * from listing", conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {
            DataList1.EditItemIndex = e.Item.ItemIndex;
            filldata();
        }
    }
}