using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        conn.ConnectionString =
            System.Configuration.ConfigurationManager.ConnectionStrings[1].ToString();
        conn.Open();
        //lblOut.Text = conn.State.ToString();
        string SQL = "select * from students";

        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.CommandText = SQL;
        comm.Connection = conn;
        System.Data.SqlClient.SqlDataReader dr;

        dr = comm.ExecuteReader();

        while (dr.Read())
        {
            lblOut.Text += dr.GetString(0) + ":" + dr.GetString(1) + "<br />";
        }

        conn.Close();
    }
}
