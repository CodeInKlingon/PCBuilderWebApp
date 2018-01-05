<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ConfigParts.ascx.cs" Inherits="WebApplication.ConfigParts" %>
<div id="partContainerDiv" class="confiogPart"  runat="server" > <div class="floatRight" style="line-height:60px;">
<asp:Label ID="lblPrice" runat="server" Text="Label" ></asp:Label>
<asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remove" />
</div>
    <asp:Panel ID="Panel1" runat="server">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Warning.png" Visible="False" Width="20px" />
<asp:ImageButton ID="imgPreview" runat="server" Height="50px" ImageUrl="~/Images/products/cpu1.jpg" OnClick="imgPreview_Click" style="width: 50px" />
&nbsp;&nbsp;&nbsp;
<asp:LinkButton ID="lblName" runat="server" OnClick="lblName_Click">LinkButton</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
       
</asp:Panel>
</div>


