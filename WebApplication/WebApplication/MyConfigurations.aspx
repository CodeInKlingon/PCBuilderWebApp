<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="MyConfigurations.aspx.cs" Inherits="WebApplication.MyConfigurations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:MultiView ID="MultiView1" runat="server">
    <asp:View ID="View1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Conif_Id" DataSourceID="SqlDataSourceMyConfigurations">
            <Columns>
                <asp:BoundField DataField="Conif_Id" HeaderText="Conif_Id" ReadOnly="True" SortExpression="Conif_Id" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="ConfigName" HeaderText="ConfigName" SortExpression="ConfigName" />
                <asp:BoundField DataField="DateCreated" HeaderText="DateCreated" SortExpression="DateCreated" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceMyConfigurations" runat="server" ConnectionString="<%$ ConnectionStrings:Databas1ConnectionString %>" SelectCommand="SELECT * FROM [Configs] WHERE ([Username] = @Username)">
            <SelectParameters>
                <asp:SessionParameter Name="Username" SessionField="Username" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <h1>My Configurations</h1>
        <asp:PlaceHolder ID="configPlaceHolder" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    </asp:View>
</asp:MultiView>
</asp:Content>
