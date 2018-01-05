<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Default1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <p>
    <h1>Featured Products</h1>
    <p>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="553px" ImageUrl="~/Images/Promo1.png" OnClick="ImageButton2_Click" Width="1197px" />
    </p>
    
    <h1>&nbsp;</h1>
    <h1>Build Your Dream PC Today</h1>
    <p>Register for an account today and get started building! Create multiple configurations and save them for latter. When you are ready select a configuration for purchase and we will send it right out to you.</p>
<p>
    &nbsp;</p>
<h1>Promo Codes!</h1>
    <p>Use one of these promo codes at checkout to receive a discount off your purchase.</p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <img alt="" src="Images/Code1.png" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <img alt="" src="Images/Code2.png" /></p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
