<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <span class="FormCenter"><h1>Register</h1></span><br />
    <br />
    <br />
    <br /><br />
    <span class="FormCenter">Username</span>
    <asp:TextBox ID="txtUsername" runat="server" ValidationGroup="register"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required" ValidationGroup="valid"></asp:RequiredFieldValidator>
    <br />
    <span class="FormCenter">Password</span>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ValidationGroup="register"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword" ErrorMessage="A password is required" ValidationGroup="valid"></asp:RequiredFieldValidator>
    <br />
    <span class="FormCenter">Confirm Password</span>
    <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" ValidationGroup="register"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtPassword2" ErrorMessage="The passwords do not match" ValidationGroup="valid"></asp:CompareValidator>
    <br />
    <br />
    <span class="FormCenter">Email</span>
    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" ValidationGroup="register"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please enter a valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="valid"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="lblStatus" runat="server"></asp:Label>
&nbsp;<br />
    &nbsp;<br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" CssClass="center" OnClick="btnSubmit_Click" Text="Submit" />
    <br />
    <br />
</asp:Content>
