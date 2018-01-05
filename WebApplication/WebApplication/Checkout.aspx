<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="WebApplication.Checkout" Theme="LabelSkin1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Checkout
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h2>Checkout</h2>
    <hr style=" border-top: 1px dashed black;" class="inner" />
    <br /><div class="billing"><strong>
    <br />
    Shipping and Billing Information</strong><br />
        <br />
        Name<asp:TextBox ID="TextBox1" runat="server" Width="192px"></asp:TextBox>
        <br />
        Address<asp:TextBox ID="TextBox2" runat="server" Width="311px"></asp:TextBox>
        <br />
        Provence<asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>NL</asp:ListItem>
        <asp:ListItem>PE</asp:ListItem>
        <asp:ListItem>NS</asp:ListItem>
        <asp:ListItem>NB</asp:ListItem>
        <asp:ListItem>QC</asp:ListItem>
        <asp:ListItem>ON</asp:ListItem>
        <asp:ListItem>MB</asp:ListItem>
        <asp:ListItem>SK</asp:ListItem>
        <asp:ListItem>AB</asp:ListItem>
        <asp:ListItem>BC</asp:ListItem>
        <asp:ListItem>YT</asp:ListItem>
        <asp:ListItem>NT</asp:ListItem>
        <asp:ListItem>NU</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp; Postal Code<asp:TextBox ID="TextBox3" runat="server" Width="75px"></asp:TextBox>
        <br />
        <br />
        <br />
        <strong>Payment Information</strong><br />
        <br />
        Card Number<asp:TextBox ID="TextBox4" runat="server" Width="222px"></asp:TextBox>
        <br />
        Expiry Date<asp:TextBox ID="TextBox5" runat="server" Width="49px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Security Code<asp:TextBox ID="TextBox6" runat="server" Width="62px"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="btnPurchase" runat="server" CssClass="purchaseButton" Text="Complete Order" />
    </div>
    <div style=" width:400px; float:left; margin-left:50px;">
    <asp:Table ID="tblOrderItems" runat="server" style="height: 24px">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" Font-Bold="True" Width="350px">Items</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True" Width="35px">Price</asp:TableCell>
        </asp:TableRow>

    </asp:Table>
    <br />
    &nbsp;Have a coupon?<br>
    &nbsp;<asp:TextBox ID="txtCouponCode" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Apply Coupon" Height="20px" Width="100px" />
    <asp:Label ID="lblCouponStatus" runat="server" ForeColor="Red"></asp:Label>
    </div><p style="clear:both;">&nbsp;</p>
</asp:Content>
