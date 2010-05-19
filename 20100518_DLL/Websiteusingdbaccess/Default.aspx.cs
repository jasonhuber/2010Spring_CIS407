using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }

    }

    private void LoadData()
    {
        DataAccess.db myDA = new DataAccess.db();
        System.Data.SqlClient.SqlDataReader dr;
        myDA.connectionstring = "Data Source=devrystudentsp10.db.6077598.hostedresource.com;Initial Catalog=DeVryStudentSP10;User Id=DeVryStudentSP10;Password=OidLZqBv4;";
        dr = myDA.GetData("select * from tbluserlogin");

        while (dr.Read())
        {
            Response.Write(dr.GetValue(1).ToString() + "<br />");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string SQL = "insert into tbluserlogin ( username, userpassword, securitylevel) values ('" + TextBox1.Text + "','anything','A');";
        DataAccess.db myDA = new DataAccess.db();
        myDA.connectionstring = "Data Source=devrystudentsp10.db.6077598.hostedresource.com;Initial Catalog=DeVryStudentSP10;User Id=DeVryStudentSP10;Password=OidLZqBv4;";
        myDA.Execute(SQL);
        LoadData();

    }
}