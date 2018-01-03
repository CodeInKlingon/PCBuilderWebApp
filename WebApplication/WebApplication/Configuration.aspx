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
            <asp:Panel ID="Panel2" runat="server">
    <asp:Button ID="btnCPU" runat="server" CssClass="PartCategoryButton" Text="CPU" OnClick="Button1_Click" />
    <asp:Button ID="btnMotherboard" runat="server" CssClass="PartCategoryButton" Text="Motherboard" OnClick="Button2_Click" />
    <asp:Button ID="btnMemory" runat="server" CssClass="PartCategoryButton" Text="Memory" OnClick="Button3_Click" />
    <asp:Button ID="btnStorage" runat="server" CssClass="PartCategoryButton" Text="Storage" OnClick="Button4_Click" />
    <asp:Button ID="btnVideo" runat="server" CssClass="PartCategoryButton" Text="Video Cards" OnClick="Button5_Click" />
    <asp:Button ID="btnPower" runat="server" CssClass="PartCategoryButton" Text="Power Supplies" OnClick="Button6_Click" />
    <asp:Button ID="btnCases" runat="server" CssClass="PartCategoryButton" Text="Cases" OnClick="Button7_Click" />
            </asp:Panel>
            <p style="clear:both;">

            </p>

        </asp:View>
    </asp:MultiView>
    
</asp:Content>
