using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string sconnectionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + MapPath("./app_data/Huber_SP10Class.mdb");
        string sconnectionstring = "Data Source=devrystudentsp10.db.6077598.hostedresource.com;Initial Catalog=devrystudentsp10;User Id=DeVryStudentSP10;Password=;";
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(sconnectionstring);
        conn.Open();

        string sql = "select * from huber_students";

        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand(sql, conn);

        System.Data.SqlClient.SqlDataReader dr;
        dr = comm.ExecuteReader();

        while (dr.Read())
        {
            Response.Write(dr.GetValue(1).ToString() + "<br />");
        }

        //Response.Write(conn.State);
        conn.Close();

        //System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection(sconnectionstring);
        //conn.Open();

        //string sql = "select * from huber_students";

        //System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand(sql, conn);

        //System.Data.OleDb.OleDbDataReader dr;
        //dr = comm.ExecuteReader();

        //while (dr.Read())
        //{
        //    Response.Write(dr.GetValue(1).ToString() + "<br />");
        //}

        ////Response.Write(conn.State);
        //conn.Close();

    }
}
