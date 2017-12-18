<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Configuration.aspx.cs" Inherits="WebApplication.Configuration" %>

<%@ Register Src="~/AddPart.ascx" TagPrefix="uc1" TagName="AddPart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Configuration
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:MultiView ID="MultiView2" runat="server">
        <asp:View ID="View4" runat="server">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ConfigItem_Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="ConfigItem_Id" HeaderText="ConfigItem_Id" ReadOnly="True" SortExpression="ConfigItem_Id" />
                    <asp:BoundField DataField="Config_Id" HeaderText="Config_Id" SortExpression="Config_Id" />
                    <asp:BoundField DataField="Product_Id" HeaderText="Product_Id" SortExpression="Product_Id" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Databas1ConnectionString %>" SelectCommand="SELECT * FROM [ConfigItems] WHERE ([Config_Id] = @Config_Id)">
                <SelectParameters>
                    <asp:SessionParameter Name="Config_Id" SessionField="ConfigID" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <asp:GridView ID="ConfigGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="Conif_Id" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="Conif_Id" HeaderText="Conif_Id" ReadOnly="True" SortExpression="Conif_Id" />
                    <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                    <asp:BoundField DataField="ConfigName" HeaderText="ConfigName" SortExpression="ConfigName" />
                    <asp:BoundField DataField="DateCreated" HeaderText="DateCreated" SortExpression="DateCreated" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Databas1ConnectionString %>" SelectCommand="SELECT * FROM [Configs] WHERE ([Conif_Id] = @Conif_Id)">
                <SelectParameters>
                    <asp:SessionParameter Name="Conif_Id" SessionField="ConfigID" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </asp:View>
        <asp:View ID="View5" runat="server">
            <br />
    <asp:Label ID="Label1" runat="server" Text="Configuration Name" CssClass="textHeading"></asp:Label>&nbsp;&nbsp; 
    <asp:TextBox ID="txtConfigName" runat="server"></asp:TextBox>
<br />
    <br />
    <br />
    <asp:Button ID="Button8" runat="server" CssClass="PartCategoryButton" Text="CPU" />
    <asp:Button ID="Button2" runat="server" CssClass="PartCategoryButton" Text="Motherboard" />
    <asp:Button ID="Button3" runat="server" CssClass="PartCategoryButton" Text="Storage" />
    <br />
    <asp:Button ID="Button4" runat="server" CssClass="PartCategoryButton" Text="Memory" />
    <asp:Button ID="Button5" runat="server" CssClass="PartCategoryButton" Text="Video Cards" />
    <asp:Button ID="Button6" runat="server" CssClass="PartCategoryButton" Text="Power Supplies" />
    <br />
    <asp:Button ID="Button7" runat="server" CssClass="PartCategoryButton" Text="Cases" />

        </asp:View>
    </asp:MultiView>
    
</asp:Content>
