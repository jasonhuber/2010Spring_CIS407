using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page3 : System.Web.UI.Page
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
        System.Data.DataSet ds = new System.Data.DataSet();
        System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();

        da.SelectCommand = comm;
        da.Fill(ds);

        rptDisplay.DataSource = ds.Tables[0];
        rptDisplay.DataBind();


        grdDisplay.DataSource = ds.Tables[0];
        grdDisplay.DataBind();

        System.Data.DataSet dsxml = new System.Data.DataSet();
        dsxml.ReadXml(Server.MapPath("students.xml"));

        grdXml.DataSource = dsxml.Tables[0];
        grdXml.DataBind();


        conn.Close();
    }
}
