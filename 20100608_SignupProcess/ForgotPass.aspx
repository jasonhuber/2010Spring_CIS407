<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ForgotPass.aspx.cs" Inherits="ForgotPass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
Username OR email<asp:textbox ID="txtUsernameOrEmail" runat="server" /><br />
<asp:Button ID="btnForgot" runat="server" Text="Forgot Password" 
        onclick="btnForgot_Click" /><br />

<asp:Label ID="lblMessage" runat="server" />
</asp:Content>

