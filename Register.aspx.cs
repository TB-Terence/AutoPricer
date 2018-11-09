using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


    public partial class Register : System.Web.UI.Page
    {
        string connectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["xxxxxxxx"].ToString(); // enter connections string name
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand("SELECT Username FROM User WHERE Username=@username", conn);
            comm.Parameters.AddWithValue("@username", tbUsername.Text);
            if (Convert.ToInt16(comm.ExecuteScalar()) != 0)//if account already taken
            {
                labelWarning.Text = "Username taken!";
            }
            else //insert into database and send email
            {
                SqlCommand comm2 = new SqlCommand("INSERT INTO user(Username,Password,Email,Address,PhoneNumber,AccountType) values(@username, @password, @email, @address, @phone,Unactivated)", conn);
                comm.Parameters.AddWithValue("@username", tbUsername.Text);
                comm.Parameters.AddWithValue("@password", tbPassword.Text);
                comm.Parameters.AddWithValue("@email", tbEmail.Text);
                comm.Parameters.AddWithValue("@address", tbAddress.Text);
                comm.Parameters.AddWithValue("@phone", tbPhone.Text);
                try
                {
                    comm2.ExecuteNonQuery();
                    sendEmail();
                    Response.Redirect("~/EmailConfirmation.aspx");
                }
                catch (SqlException ex)
                {
                    labelWarning.Text = "failed to insert to database!";
                }
            }
        }

        private void sendEmail()//sending a email to client to confirm account
        {
            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;

            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("TeamNKproject@gmail.com", "teamnk1!");
            client.UseDefaultCredentials = false;
            client.Credentials = credentials;

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("TeamNKproject@gmail.com");
            msg.To.Add(new MailAddress(tbEmail.Text));

            msg.Subject = "Email confirmation";
            msg.IsBodyHtml = true;
            msg.Body = string.Format("<html><head></head><body>Please click on the following link to confirm your account<br/>" +
                "If you did not create an account with us, please ignore this email<br/>" +
                "<a href=\"~/Login.aspx?emailConfirm=true\">click here and login</body>");//confirmation link, need integration testing

            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                labelWarning.Text = "failed to send email!";
            }
        }
    }
