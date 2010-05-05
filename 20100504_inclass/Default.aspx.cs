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
        if (Session["counted"] == null)
        {
            if (Application["currentUsers"] == null)
            {
                Application["currentUsers"] = 1;
            }
            else
            {
                Application["currentUsers"] = (int)Application["currentUsers"] + 1;
            }
            Session["counted"] = true;
        }
        
        string strVar = System.Configuration.ConfigurationSettings.AppSettings["JasonStatic"];
        Response.Write(Application["currentUsers"] + "\n<br /> " + strVar + "\n<br /> ");
        Response.Write(Request.ServerVariables["REMOTE_ADDR"]);
        if (IsPostBack)
        {
            Response.Write("true!");
        }
        else 
        {
            Response.Write("false!");
        }
        //web page stuff
        System.Data.Odbc.OdbcConnection conn = new System.Data.Odbc.OdbcConnection();
        conn.ConnectionString =
            "Driver={MySQL ODBC 5.1 Driver};Server=;Database=kennedyhuber;User=kennedyhuber; Password=;Option=3;";
        conn.Open();
        string sql = "select * from bloggers";
        System.Data.Odbc.OdbcDataReader DR;
        System.Data.Odbc.OdbcCommand comm 
            = new System.Data.Odbc.OdbcCommand(sql, conn);

        DR = comm.ExecuteReader();
        while (DR.Read())
        {
            Response.Write("<br /> Blogger:" + DR[0].ToString());
        }
        conn.Close();


    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblResults.Text = txtName.Text;
        pnlResults.Visible = true;
        pnlPage1.Visible = false;
    }
}
