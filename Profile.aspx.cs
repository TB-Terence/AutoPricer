using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Profile : System.Web.UI.Page
{
    string connectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        connectionString = ConfigurationManager.ConnectionStrings["database"].ToString();
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Home.aspx");
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand comm = new SqlCommand("INSERT INTO CreditCard (CardNumber,ExpireDate,CVD) VALUES (@CardNumber,@ExpireDate,@CVD ", conn);
        comm.Parameters.AddWithValue("@CardNumber", tbUsername.Text);
        comm.Parameters.AddWithValue("@ExpireDate", tbPassword.Text);
        comm.Parameters.AddWithValue("@CVD", tbPassword.Text);

        try
        {
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception)
        {
        }
    }
}