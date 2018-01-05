<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

                <h1>Login</h1>
                Username<asp:TextBox ID="txtUsername" runat="server" ValidationGroup="login"></asp:TextBox>
                <br />
                Password<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ValidationGroup="login"></asp:TextBox>
                <br />
                <asp:Button ID="btnLogin2" runat="server" OnClick="btnLogin2_Click" Text="Login" ValidateRequestMode="Enabled" ValidationGroup="login" />
                &nbsp;&nbsp;&nbsp;
<asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
                <br />
                <asp:Label ID="lblLoginStatus" runat="server" Text=""></asp:Label>

</asp:Content>
