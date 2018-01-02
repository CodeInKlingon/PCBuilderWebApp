<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ConfigParts.ascx.cs" Inherits="WebApplication.ConfigParts" %>
<asp:ImageButton ID="imgPreview" runat="server" Height="50px" ImageUrl="~/Images/products/cpu1.jpg" OnClick="imgPreview_Click" style="width: 50px" />
&nbsp;&nbsp;&nbsp;
<asp:LinkButton ID="lblName" runat="server" OnClick="lblName_Click">LinkButton</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
<asp:Label ID="lblPrice" runat="server" Text="Label"></asp:Label>
<asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remove" />
<p>
    &nbsp;</p>

