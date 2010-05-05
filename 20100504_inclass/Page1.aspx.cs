using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Page1 : System.Web.UI.Page 
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
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblResults.Text = txtName.Text;
        pnlResults.Visible = true;
        pnlPage1.Visible = false;
    }
}
