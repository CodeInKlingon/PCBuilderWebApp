<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <span class="FormCenter">Username</span>
    <asp:TextBox ID="txtUsername" runat="server" ValidationGroup="register"></asp:TextBox>
    <br />
    <span class="FormCenter">Password</span>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ValidationGroup="register"></asp:TextBox>
    <br />
    <span class="FormCenter">Confirm Password</span>
    <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" ValidationGroup="register"></asp:TextBox>
    <br />
    <br />
    <span class="FormCenter">Email</span>
    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" ValidationGroup="register"></asp:TextBox>
    <br />
    <asp:Label ID="lblStatus" runat="server"></asp:Label>
&nbsp;<br />
    &nbsp;<br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" CssClass="center" OnClick="btnSubmit_Click" Text="Submit" />
    <br />
    <br />
</asp:Content>
