using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class verifyuser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["authcode"] != null)
        {
            if (CheckParamAgainstDB(Server.UrlDecode(Request.Params["authcode"].ToString())) >= 1)
            {
                lblMessage.Text = "You are authenticated! Go login!";
            }
            else
            {
                lblMessage.Text = "You are NOT authenticated! ";
            }
        }
    }

    private int CheckParamAgainstDB(string Param)
    {
        //http://localhost:55334/20100608_SignupProcess/verifyuser.aspx?authcode=vv%23y%5eHx3n6T4%7c%60-C%7e%2673
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        conn.ConnectionString = @"Data Source=devrystudentsp10.db.6077598.hostedresource.com;Initial Catalog=devrystudentsp10;User Id=devrystudentsp10;Password=OidLZqBv4;";
        conn.Open();
        //lblOut.Text = conn.State.ToString();
        string SQL = "update huber_logins set temppass  = 'active' where temppass = @temppass";

        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.CommandText = SQL;
        comm.Connection = conn;
        comm.Parameters.AddWithValue("@temppass", Param);

        return comm.ExecuteNonQuery();
    
    }
}