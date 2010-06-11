using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//ref: http://www.mikesdotnetting.com/Article/96/Handling-JSON-Arrays-returned-from-ASP.NET-Web-Services-with-jQuery

namespace JSONWebServiceTest
{
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
    
    /// <summary>
    /// Summary description for Trucks
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Trucks : System.Web.Services.WebService
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


        [WebMethod]
        public List<UhaulTruck> GetTrucks()
        {
            return myTrucks;
        }
        [WebMethod]
        public List<UhaulTruck> GetTrucks(int mincapacity)
        {
            var query = from t in myTrucks
                        where t.capacity > mincapacity
                        select t;
            return query.ToList();

        }

    }
}
