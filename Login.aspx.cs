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
        string connectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["database"].ToString(); // enter connections string name
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand("SELECT AccountType FROM User WHERE Username=@username AND Password=@password ", conn);
            comm.Parameters.AddWithValue("@username", tbUsername.Text);
            comm.Parameters.AddWithValue("@password", tbPassword.Text);
            if (Convert.ToInt16(comm.ExecuteScalar()) != 0)
            {
                if (true)//if is admin
                    Response.Redirect("~/Admin.aspx");
                else//if is regular user
                {
                    string emailConfirm = Request.QueryString["emailConfirm"];//check if we need to set the email activation
                    if (emailConfirm.Equals("true"))
                    {
                        //emailConfirm();
                    }
                    Response.Redirect("~/User.aspx");
                }
            }
            else
            {
                labelWarning.Text = "Username or password incorrect!";
            }

        }

        private void emailConfirm()//set the user account type to activated
        {
            SqlConnection conn = new SqlConnection(connectionString);
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
