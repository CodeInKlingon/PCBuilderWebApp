﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ConfigListItemControl.ascx.cs" Inherits="WebApplication.ConfigListItemControl" %>
<div class="configListItem">
    <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Edit" />
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Config Name: "></asp:Label>
    <asp:Label ID="lblConfigName" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Date Created: "></asp:Label>
    <asp:Label ID="lblDate" runat="server" Text="Label" Width="180px"></asp:Label>

    &nbsp;&nbsp;&nbsp;

    <asp:Button ID="btnDelete" runat="server" Text="Delete" />

</div>



