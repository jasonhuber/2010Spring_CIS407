using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Trucks : System.Web.UI.Page
{
    List<UhaulTruck> myTrucks = new List<UhaulTruck>{
                new UhaulTruck{capacity=1538,GVW=18200,Emptyweight=12500,dimensions="22 ft by 33 ft",features="a/c,cruise",fuel="diesel",price="4000"},
                new UhaulTruck{capacity=900,GVW=18200,Emptyweight=12500,dimensions="22 ft by 33 ft",features="a/c,cruise",fuel="diesel",price="4000"},
                new UhaulTruck{capacity=2000,GVW=18200,Emptyweight=12500,dimensions="22 ft by 33 ft",features="a/c,cruise",fuel="diesel",price="4000"},
                new UhaulTruck{capacity=3000,GVW=18200,Emptyweight=12500,dimensions="22 ft by 33 ft",features="a/c,cruise",fuel="diesel",price="4000"},
                new UhaulTruck{capacity=4000,GVW=18200,Emptyweight=12500,dimensions="22 ft by 33 ft",features="a/c,cruise",fuel="diesel",price="4000"},
                new UhaulTruck{capacity=5000,GVW=18200,Emptyweight=12500,dimensions="22 ft by 33 ft",features="a/c,cruise",fuel="diesel",price="4000"},
                new UhaulTruck{capacity=1000,GVW=18200,Emptyweight=12500,dimensions="22 ft by 33 ft",features="a/c,cruise",fuel="diesel",price="4000"},
            };


      
  
protected void  Page_Load(object sender, EventArgs e)
    {
   
    GridView1.DataSource= myTrucks;
    GridView1.DataBind();

    }
}
 public class UhaulTruck
    {
       public int capacity;
       public int GVW;
       public int Emptyweight;
       public string dimensions;
       public string features;
       public string fuel;
       public string price;
    }
