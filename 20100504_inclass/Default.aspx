<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="pnlPage1" runat="server">
        <asp:TextBox ID="txtName" runat="server" Text="Jason" />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit Me" 
            onclick="btnSubmit_Click" />
    </asp:Panel>
    <asp:Panel ID="pnlResults" runat="server" Visible="false">
        <asp:Label ID="lblResults" runat="server" />
    </asp:Panel>
            
    </div>
    </form>
</body>
</html>
