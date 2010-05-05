<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Page1.aspx.cs" Inherits="_Page1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="pnlPage1" runat="server">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <asp:TextBox ID="txtName" runat="server" Text="Jason" />
        <asp:RegularExpressionValidator ID="validName" runat="server" 
            ControlToValidate="txtName" ErrorMessage="You must enter an email." 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
            Text="Submit Me" />
    </asp:Panel>
    <asp:Panel ID="pnlResults" runat="server" Visible="false">
        <asp:Label ID="lblResults" runat="server" />
    </asp:Panel>
            
    </div>
    <asp:ValidationSummary ID="ValidationSummary2" runat="server" />
    </form>
</body>
</html>
