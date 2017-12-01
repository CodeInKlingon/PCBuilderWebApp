<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Configuration.aspx.cs" Inherits="WebApplication.Configuration" %>

<%@ Register Src="~/AddPart.ascx" TagPrefix="uc1" TagName="AddPart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Configuration
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Configuration Name" CssClass="textHeading"></asp:Label>&nbsp;&nbsp; <asp:TextBox ID="txtConfigName" runat="server" Font-Size="X-Large" Height="28px" Width="396px">MyConfig</asp:TextBox>
<br />
    <br />
    <br />
    <div id="SumamryBar">
        Price<br />
        <hr />
        Total: $0<br />
        <asp:Button ID="Button1" runat="server" Text="Checkout" />
    </div>
    <asp:Label ID="Label2" runat="server" Text="Your Selected Parts" Font-Size="X-Large"></asp:Label><br />
    None.<br />
&nbsp;<uc1:AddPart runat="server" id="AddPart" />

</asp:Content>
