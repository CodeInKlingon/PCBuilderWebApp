<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PartsListItem.ascx.cs" Inherits="WebApplication.PartsListItem" %>
<div class="pli">
<asp:ImageButton ID="imgPreview" runat="server" Height="50px" ImageUrl="~/Images/products/cpu1.jpg" OnClick="imgPreview_Click" style="width: 50px" />
&nbsp;&nbsp;&nbsp;
<asp:LinkButton ID="lblName" runat="server" OnClick="lblName_Click">LinkButton</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
<asp:Label ID="lblPrice" runat="server" Text="Label"></asp:Label>
</div>


