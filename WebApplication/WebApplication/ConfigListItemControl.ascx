<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ConfigListItemControl.ascx.cs" Inherits="WebApplication.ConfigListItemControl" %>
<div class="configListItem">
    <div class="floatRight" style:"padding-left:10px;">
    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="cliDelete" Width="65px" />
        </div>
    <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Select" CssClass="cliSelect" Width="67px" />
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Config Name: "></asp:Label>
    <asp:Label ID="lblConfigName" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Date Created: "></asp:Label>
    <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>

    &nbsp;&nbsp;&nbsp;
    
</div>



