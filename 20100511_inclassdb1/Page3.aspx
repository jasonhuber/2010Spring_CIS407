<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page3.aspx.cs" Inherits="Page3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="rptDisplay" runat="server">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li><%# DataBinder.Eval(Container.DataItem, "name") %></li>
            </ItemTemplate>
            
            <FooterTemplate></ul></FooterTemplate>
        </asp:Repeater>
        
        <asp:GridView ID="grdDisplay" runat="server">
        </asp:GridView>
        <asp:GridView ID="grdXml" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
