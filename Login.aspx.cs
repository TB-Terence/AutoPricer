using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Register.aspx");
    }

    protected void login_Authenticate(object sender, AuthenticateEventArgs e)
    {
        // Define data objects
        SqlConnection conn;
        SqlDataAdapter adapter;
        string connectionString =
            ConfigurationManager.ConnectionStrings[
            "database"].ConnectionString;
        // Initialize connection
        conn = new SqlConnection(connectionString);
        try
        {
            // Create command
            adapter = new SqlDataAdapter(
                "SELECT Username FROM User WHERE Username = '" + login.UserName + "' AND Password ='" + login.Password + "'",
                conn);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count != 0)
            {
                FormsAuthentication.RedirectFromLoginPage
                    (login.UserName, login.RememberMeSet);


                HttpCookie cookie = Request.Cookies.Get("username");
                //Response.Cookies.Get will reset cookies
                if (cookie == null)
                {
                    cookie = new HttpCookie("username");

                    cookie.Value = login.UserName;
                    Response.Cookies.Add(cookie);

                }
                else
                {
                    cookie.Value = login.UserName;
                    Response.Cookies.Add(cookie);
                }

            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            // Close the connection
            conn.Close();
        }
    }

}
