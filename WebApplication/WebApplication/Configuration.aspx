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
    <asp:TextBox ID="txtConfigName" runat="server"  AutoPostBack="true" OnTextChanged="txtConfigName_TextChanged">ConfigNameGoesHere</asp:TextBox>
            <asp:Button ID="btnSave" runat="server" Text="Update Name" OnClick="btnSave_Click" />
            <br />
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
<br />
    <br />
    <br />
    <asp:Button ID="Button8" runat="server" CssClass="PartCategoryButton" Text="CPU" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" CssClass="PartCategoryButton" Text="Motherboard" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" CssClass="PartCategoryButton" Text="Storage" OnClick="Button3_Click" />
    <asp:Button ID="Button4" runat="server" CssClass="PartCategoryButton" Text="Memory" OnClick="Button4_Click" />
    <asp:Button ID="Button5" runat="server" CssClass="PartCategoryButton" Text="Video Cards" OnClick="Button5_Click" />
    <asp:Button ID="Button6" runat="server" CssClass="PartCategoryButton" Text="Power Supplies" OnClick="Button6_Click" />
    <br />
    <asp:Button ID="Button7" runat="server" CssClass="PartCategoryButton" Text="Cases" OnClick="Button7_Click" />

            <br />
            <br />
            <br />
            <br />

        </asp:View>
    </asp:MultiView>
    
</asp:Content>
