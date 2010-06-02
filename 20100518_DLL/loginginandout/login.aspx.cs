using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        conn.ConnectionString = @"Data Source=devrystudentsp10.db.6077598.hostedresource.com;Initial Catalog=devrystudentsp10;User Id=devrystudentsp10;Password=OidLZqBv4;";
        conn.Open();
        //lblOut.Text = conn.State.ToString();
        string SQL = "select * from Huber_login where username = @username and password = @password";

        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.CommandText = SQL;
        comm.Connection = conn;
        comm.Parameters.AddWithValue("@username", txtUserName.Text);
        comm.Parameters.AddWithValue("@password", txtPassword.Text);

        object myvar = comm.ExecuteScalar();

        if (myvar != null)
	{
        //            System.Web.Security.FormsAuthentication.RedirectFromLoginPage(txtUserName.Text,false);

            System.Web.Security.FormsAuthentication.SetAuthCookie(txtUserName.Text,false);
            Response.Redirect("securedpage3.aspx");
	}

        comm = null;
        conn.Close();

        //if (System.Web.Security.FormsAuthentication.Authenticate(txtUserName.Text, txtPassword.Text))
        //{
        //    System.Web.Security.FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
        //}
        //else
        //{
        //    Response.Write("You were not logged in!");
        //}

    }
}