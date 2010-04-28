<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<%@ Register src="leftlinks.ascx" tagname="leftlinks" tagprefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script language="javascript">
        alert("default alert");
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="middle" Runat="Server">
        middle of default
&nbsp;<br />
        
        middle of default <br />
        
        middle of default <br />
        
        middle of default <br />
        
        middle of default <br />
        
        middle of default <br />
        
        middle of default <br />
        
        middle of default <br />
        
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="right" Runat="Server">
 <uc1:leftlinks ID="leftlinks2" runat="server" />
 </asp:Content>