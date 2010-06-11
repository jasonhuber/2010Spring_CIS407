<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JSONWebServiceTest.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    
    <script  type="text/javascript"  src="http://ajax.googleapis.com/ajax/libs/jquery/1.3/jquery.min.js"></script>

<script type="text/javascript">
    $(function() {
        $('#Button1').click(getTrucksClientSide); //this ties the click event of the button below to the method getTrucksClientSide
    });

    /*
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

    */
    function getTrucksClientSide() {
        $.ajax({
            type: "POST",
            url: "Trucks.asmx/GetTrucks",
            data: "{mincapacity:1000}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(response) {
                var myTrucks = (typeof response.d) == 'string' ? eval('(' + response.d + ')') : response.d;
                $('#output').empty();
                for (var i = 0; i < myTrucks.length; i++) {
                    $('#output').append('<p><strong>' + myTrucks[i].price + ' Capacity:' +
                                myTrucks[i].capacity + '</strong><br /> GVW: ' +
                                myTrucks[i].GVW + '<br />Empty Weight: ' +
                                myTrucks[i].Emptyweight + '<br />Dimensions: ' +
                                myTrucks[i].dimensions + '<br />fuel: ' +
                                myTrucks[i].fueld+ '<br />features: ' +
                                myTrucks[i].features + '</p>');
                }
            },
            failure: function(msg) {
                $('#output').text(msg);
            }
        });
    }
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input  type="button" id="Button1" value="Get Trucks" />

<div id="output"></div>
    </div>
    </form>
</body>
</html>
