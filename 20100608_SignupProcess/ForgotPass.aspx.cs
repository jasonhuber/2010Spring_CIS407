using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ForgotPass : System.Web.UI.Page
{
  
    protected void btnForgot_Click(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        conn.ConnectionString = @"Data Source=devrystudentsp10.db.6077598.hostedresource.com;Initial Catalog=devrystudentsp10;User Id=devrystudentsp10;Password=OidLZqBv4;";
        conn.Open();
        //lblOut.Text = conn.State.ToString();
        string SQL = "select password, email from huber_logins where username = @username OR email = @email";

        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.CommandText = SQL;
        comm.Connection = conn;
        comm.Parameters.AddWithValue("@username", txtUsernameOrEmail.Text);
        comm.Parameters.AddWithValue("@email", txtUsernameOrEmail.Text);
        System.Data.SqlClient.SqlDataReader dr;

        dr = comm.ExecuteReader();

        if (dr.HasRows)
        {
            dr.Read();
            SendEmail(dr.GetString(0), dr.GetString(1));
            lblMessage.Text = "Your password was emailed!";
        }
        else
        {
            lblMessage.Text     = "Username and/or email not found";
        }

    }
    private void SendEmail(string password, string Email)
    {
        string sbody = "";
        System.Net.Mail.MailMessage MM = new System.Net.Mail.MailMessage();
        MM.To.Add(Email);
        MM.From = new System.Net.Mail.MailAddress("website@hub3r.com");
        MM.Subject = "Your login information";
        MM.IsBodyHtml = true;
        sbody = "Your password is: " + password;
        MM.Body = sbody;
        System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
        smtp.Host = "127.0.0.1";
        smtp.Port = 25;
        // smtp.Send(MM);
    }
 
}