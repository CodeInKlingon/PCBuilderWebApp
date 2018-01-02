<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Configuration.aspx.cs" Inherits="WebApplication.Configuration" %>

<%@ Register Src="~/AddPart.ascx" TagPrefix="uc1" TagName="AddPart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Configuration
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:MultiView ID="MultiView2" runat="server" ActiveViewIndex="0">
        <asp:View ID="View5" runat="server">
            <br />
    <asp:Label ID="Label1" runat="server" Text="Configuration Name" CssClass="textHeading"></asp:Label>&nbsp;&nbsp; 
    <asp:TextBox ID="txtConfigName" runat="server" OnTextChanged="txtConfigName_TextChanged">ConfigNameGoesHere</asp:TextBox>
            <asp:Button ID="btnSave" runat="server" Text="Save" Visible="False" />
            <br />
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
<br />
    <br />
    <br />
    <asp:Button ID="Button8" runat="server" CssClass="PartCategoryButton" Text="CPU" />
    <asp:Button ID="Button2" runat="server" CssClass="PartCategoryButton" Text="Motherboard" />
    <asp:Button ID="Button3" runat="server" CssClass="PartCategoryButton" Text="Storage" />
    <asp:Button ID="Button4" runat="server" CssClass="PartCategoryButton" Text="Memory" />
    <asp:Button ID="Button5" runat="server" CssClass="PartCategoryButton" Text="Video Cards" />
    <asp:Button ID="Button6" runat="server" CssClass="PartCategoryButton" Text="Power Supplies" />
    <br />
    <asp:Button ID="Button7" runat="server" CssClass="PartCategoryButton" Text="Cases" />

            <br />
            <br />
            <br />
            <br />

        </asp:View>
    </asp:MultiView>
    
</asp:Content>
