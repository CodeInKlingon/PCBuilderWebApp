<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Parts.aspx.cs" Inherits="WebApplication.Parts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View2" runat="server">
            <asp:Button ID="Button1" runat="server" Text="CPU" CssClass="PartCategoryButton" />
            <asp:Button ID="Button2" runat="server" CssClass="PartCategoryButton" Text="Motherboard" />
            <asp:Button ID="Button3" runat="server" CssClass="PartCategoryButton" Text="Storage" />
            <br />
            <asp:Button ID="Button4" runat="server" CssClass="PartCategoryButton" Text="Memory" />
            <asp:Button ID="Button5" runat="server" CssClass="PartCategoryButton" Text="Video Cards" />
            <asp:Button ID="Button6" runat="server" CssClass="PartCategoryButton" Text="Power Supplies" />
            <br />
            <asp:Button ID="Button7" runat="server" CssClass="PartCategoryButton" Text="Cases" />
        </asp:View>
        <asp:View ID="View1" runat="server">
            <div id="searchMenu">
                <div class="floatRight">Sort Results By: <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Popularity</asp:ListItem>
                    <asp:ListItem>Price: Highest First</asp:ListItem>
                    <asp:ListItem>Price: Lowest First</asp:ListItem>
                </asp:DropDownList></div>
                <%-- USed to show search depth --%>
                <asp:Menu ID="partsMenu" runat="server" Orientation="Horizontal">
                    <Items>
                        <asp:MenuItem Text="Parts" Value="Parts"></asp:MenuItem> 
                    </Items>
                </asp:Menu>
        
            </div>
            <div id="searchFilter">
                <br />
                Search Filters<br />
                <br />
                Manufacturer:<br />
                <asp:CheckBoxList ID="chkListMan" runat="server">
                </asp:CheckBoxList>
                <br />
                Minimum Price:<br />
                <asp:TextBox ID="TextBox1" runat="server" Columns="12" TextMode="Range">0</asp:TextBox>
                <br />
                <br />
                Maximum Price:<br />
                <asp:TextBox ID="TextBox2" runat="server" Columns="12" TextMode="Range">100</asp:TextBox>
            </div>
            <div id="searchResults">
                <br />
                <br />
                <br />
                <asp:PlaceHolder ID="PlaceHolder1" runat="server">No Results Found</asp:PlaceHolder>
                <br />
                <br />
                <br />
                <br />
            </div>
            <div class="floatRight" id="seachPages">Previous Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Next Page</div>
        </asp:View>
     </asp:MultiView>
</asp:Content>
