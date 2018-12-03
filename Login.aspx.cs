using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



    public partial class Login : System.Web.UI.Page
    {

    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AutoDB.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        SqlCommand comm = new SqlCommand("SELECT AccountType FROM [User] WHERE Username=@username AND Password=@password ", conn);
        comm.Parameters.AddWithValue("@username", tbUsername.Text);
        comm.Parameters.AddWithValue("@password", tbPassword.Text);
        try
        {
            conn.Open();
            string account = "";

            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {

                account = reader[0].ToString().Trim();
            }
            reader.Close();


            if (account.Equals("admin"))
            {
                System.Web.HttpContext.Current.Session["user"] = tbUsername.Text;
                System.Web.HttpContext.Current.Session["accountType"] = "admin";
                Response.Redirect("~/Admin.aspx");
            }
            else if (account.Equals("regular"))
            {
                System.Web.HttpContext.Current.Session["user"] = tbUsername.Text;
                System.Web.HttpContext.Current.Session["accountType"] = "regular";
                Response.Redirect("~/UserProfile.aspx");
            }
            else
            {
                labelWarning.Text = "account not found";
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            tbUsername.Text = "conn not working";
        }
    }

        private void emailConfirm()//set the user account type to activated
        {
            
            SqlCommand comm = new SqlCommand("UPDATE user SET AccountType = Activated WHERE Username =@username ", conn);
            comm.Parameters.AddWithValue("@username", tbUsername.Text);
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
