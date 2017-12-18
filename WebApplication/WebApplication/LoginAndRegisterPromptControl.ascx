<style type="text/css">
    .auto-style1 {
        width: 238px;
    }
</style>
<table style="width:100%;">
    <tr>
        <td class="auto-style1">Login</td>
        <td>Register</td>

    </tr>
    <tr>
        <td class="auto-style1">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>

    </tr>
    <tr>
        <td class="auto-style1">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </td>

    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Button ID="Button2" runat="server" Text="Button" />
        </td>
        <td>&nbsp;</td>

    </tr>
</table>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginAndRegisterPromptControl.ascx.cs" Inherits="WebApplication.LoginAndRegisterPromptControl" %>
