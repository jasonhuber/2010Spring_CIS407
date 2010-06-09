using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class singmeup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSingup_Click(object sender, EventArgs e)
    {
        string authcode = "";
        try
        {
            if (!DoesUserExist(txtUsername.Text, txtEmail.Text))
            {
                CreateLogin(txtUsername.Text, txtPassword.Text, txtEmail.Text);
                authcode = GenAuthCode();
                SetAuthCodeToUser(authcode, txtUsername.Text);
                SendEmail(txtUsername.Text, txtEmail.Text, authcode);
            }

        }
        catch (Exception ex)
        {
            
            throw ex;
        }


    }
    private void SetAuthCodeToUser(string Temppass, string UserName)
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        conn.ConnectionString = @"Data Source=devrystudentsp10.db.6077598.hostedresource.com;Initial Catalog=devrystudentsp10;User Id=devrystudentsp10;Password=OidLZqBv4;";
        conn.Open();
        //lblOut.Text = conn.State.ToString();
        string SQL = "update huber_logins set temppass  = @temppass where username = @username";

        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.CommandText = SQL;
        comm.Connection = conn;
        comm.Parameters.AddWithValue("@temppass", Temppass);
        comm.Parameters.AddWithValue("@username", UserName);

        comm.ExecuteNonQuery();
    }
     private string GenAuthCode()
    {
        RandomStringGenerator myrsg = new RandomStringGenerator();
        return myrsg.NextString(20);

    }
    private void SendEmail(string Username, string Email, string temppass)
    {
        string sbody = "";
        System.Net.Mail.MailMessage MM = new System.Net.Mail.MailMessage();
        MM.To.Add(Email);
        MM.From = new System.Net.Mail.MailAddress("website@hub3r.com");
        MM.Subject = "Your login information";
        MM.IsBodyHtml = true;
        sbody = "Please click on the following link to verify your username! <a href='http://localhost:55334/20100608_SignupProcess/verifyuser.aspx?authcode=" + Server.UrlEncode(temppass) + "'>Here</a>";
        MM.Body = sbody; 
        System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
        smtp.Host = "127.0.0.1";
        smtp.Port = 25;
       // smtp.Send(MM);
    }
    
    private void CreateLogin(string Username, string Pass, string Email)
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        conn.ConnectionString = @"Data Source=devrystudentsp10.db.6077598.hostedresource.com;Initial Catalog=devrystudentsp10;User Id=devrystudentsp10;Password=OidLZqBv4;";
        conn.Open();
        //lblOut.Text = conn.State.ToString();
        string SQL = "insert into huber_logins (username, password, email) values (@username, @password, @email)";

        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.CommandText = SQL;
        comm.Connection = conn;
        comm.Parameters.AddWithValue("@username", Username);
        comm.Parameters.AddWithValue("@password", Pass);
        comm.Parameters.AddWithValue("@email", Email);

        comm.ExecuteNonQuery();
    }
    private bool DoesUserExist(string Username,  string Email)
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        conn.ConnectionString = @"Data Source=devrystudentsp10.db.6077598.hostedresource.com;Initial Catalog=devrystudentsp10;User Id=devrystudentsp10;Password=OidLZqBv4;";
        conn.Open();
        //lblOut.Text = conn.State.ToString();
        string SQL = "select * from huber_logins where username = @username OR email = @email";

        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.CommandText = SQL;
        comm.Connection = conn;
        comm.Parameters.AddWithValue("@username", Username);
        comm.Parameters.AddWithValue("@email", Email);
        object retvar;
        retvar = comm.ExecuteScalar();
        return retvar != null;
    }
}
   
      public class RandomStringGenerator
   
      {
   
      private Random r;
   
      const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
   
      const string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
   
      const string NUMBERS = "0123456789";
   
      const string SYMBOLS = @"~`!@#$%^&*()-_=+<>?:,./\[]{}|'";
   
       
   
      public RandomStringGenerator()
  
      {
  
      r = new Random();
  
      }
       
      public RandomStringGenerator(int seed)
      {
      r = new Random(seed);
      }
       
      public virtual string NextString(int length)
      {
      return NextString(length, true, true, true, true);
      }
       
      public virtual string NextString(int length, bool lowerCase, bool upperCase, bool numbers, bool symbols)
      {
      char[] charArray = new char[length];
      string charPool = string.Empty;
       
      //Build character pool
      if (lowerCase)
      charPool += LOWERCASE;
       
      if (upperCase)
      charPool += UPPERCASE;
       
      if (numbers)
      charPool += NUMBERS;
       
      if (symbols)
      charPool += SYMBOLS;
       
      //Build the output character array
      for (int i = 0; i < charArray.Length; i++)
      {
      //Pick a random integer in the character pool
      int index = r.Next(0, charPool.Length);
       
      //Set it to the output character array
      charArray[i] = charPool[index];
      }
       
      return new string(charArray);
      }
      }