using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Register : System.Web.UI.Page
{
    private static int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand comm = new SqlCommand("SELECT Username FROM User WHERE Username='" + tbUsername.Text + "'", conn);

        //comm.Parameters.AddWithValue("@username", tbUsername.Text);
        try
        {
            conn.Open();
            if (Convert.ToInt16(comm.ExecuteScalar()) != 0)//if account already taken
            {
                labelWarning.Text = "Username taken!";
            }
            SqlCommand comm2 = new SqlCommand("INSERT INTO User(Username,Password,Email,Address,PhoneNumber,AccountType) values(@username, @password, @email, @address, @phone, 'Unactivated')", conn);
            comm.Parameters.AddWithValue("@username", tbUsername.Text);
            comm.Parameters.AddWithValue("@password", tbPassword.Text);
            comm.Parameters.AddWithValue("@email", tbEmail.Text);
            comm.Parameters.AddWithValue("@address", tbAddress.Text);
            comm.Parameters.AddWithValue("@phone", tbPhone.Text);
            try
            {
                comm2.ExecuteNonQuery();
                labelWarning.Text = "Registed";
                //    sendEmail();
                //    Response.Redirect("~/EmailConfirmation.aspx");
            }
            catch (SqlException ex)
            {
                labelWarning.Text = "failed to insert to database!";
            }
        }
        catch (Exception ex) {
            labelWarning.Text = count++ + ex.Message;
        }
        finally {
            conn.Close();
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
