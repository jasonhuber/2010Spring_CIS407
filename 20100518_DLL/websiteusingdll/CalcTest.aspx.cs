using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CalcTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SimpleDLL.Calc myCalc = new SimpleDLL.Calc();
        lblOut.Text = myCalc.Add(3, 4).ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MyCalcWS.CalcWS myCalcWS = new MyCalcWS.CalcWS();
        lblOut.Text = myCalcWS.Add(3, 5);
    }
}