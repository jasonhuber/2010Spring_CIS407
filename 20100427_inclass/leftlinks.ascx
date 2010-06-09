<%@ Control Language="C#" AutoEventWireup="true" CodeFile="leftlinks.ascx.cs" Inherits="leftlinks" %>
<div class="border1">
<h3>My labs:</h3>
<a href="http://jasncab.com">Week 1</a><br />
<a href="http://jasncab.com">Week 2</a><br />
<a href="http://jasncab.com">Week 3</a><br />
<a href="http://jasncab.com">Week 4</a><br />
<a href="http://jasncab.com">Week 5</a><br />
<a href="http://jasncab.com">Week 6</a><br />
<a href="http://jasncab.com">Week 7</a><br />
</div>
<div class="border1">
<h3>Site Map:</h3>
</div>
<asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
</asp:Menu>
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />

