<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="singmeup.aspx.cs" Inherits="singmeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
    Username:     <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox> <br />
    Pass: <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox> <br />
    Verify Pass: <asp:TextBox ID="txtVerifyPassword" runat="server"></asp:TextBox> 
<asp:CompareValidator ID="CompareValidator1" runat="server" 
    ControlToCompare="txtPassword" ControlToValidate="txtVerifyPassword" 
    ErrorMessage="Passwords do not match"></asp:CompareValidator>
<br />

    Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox> <br />
    <asp:Button ID="btnSingup" runat="server" Text="Sing Me Up!" 
        onclick="btnSingup_Click" />
    
</asp:Content>

