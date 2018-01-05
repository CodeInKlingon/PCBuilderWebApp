<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="WebApplication.Checkout" Theme="LabelSkin1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Checkout
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h2>Checkout</h2>
    <hr style=" border-top: 1px dashed black;" class="inner" />
    <br /><div class="billing" style="width: 522px"><strong>
    <br />
    Shipping and Billing Information</strong><br />
        <br />
        Name<asp:TextBox ID="txtName" runat="server" Width="192px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required" ValidationGroup="valid"></asp:RequiredFieldValidator>
        <br />
        Address<asp:TextBox ID="txtAddress" runat="server" Width="311px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address is required" ValidationGroup="valid"></asp:RequiredFieldValidator>
        <br />
        Provence<asp:DropDownList ID="ddlProvince" runat="server">
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
&nbsp;&nbsp;&nbsp; City<asp:TextBox ID="txtCity" runat="server" Width="136px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCity" ErrorMessage="City is required" ValidationGroup="valid"></asp:RequiredFieldValidator>
        <br />
        Postal Code<asp:TextBox ID="txtPostal" runat="server" Width="75px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPostal" ErrorMessage="Enter a valid postal code" ValidationExpression="^\d{5}-\d{4}|\d{5}|[A-Z]\d[A-Z] \d[A-Z]\d$" ValidationGroup="valid"></asp:RegularExpressionValidator>
        <br />
        <br />
        <br />
        <strong>Payment Information</strong><br />
        <br />
        Card Number<asp:TextBox ID="txtCreditNumber" runat="server" Width="222px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCreditNumber" ErrorMessage="Credit Card is required" ValidationGroup="valid"></asp:RequiredFieldValidator>
        <br />
        Expiry Date<asp:TextBox ID="txtExpiry" runat="server" Width="49px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Security Code<asp:TextBox ID="txtSecurity" runat="server" Width="62px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtExpiry" ErrorMessage="Invalid Expiry" ValidationGroup="valid" ValidationExpression="^\d{2}\ \d{2}$"></asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtSecurity" ErrorMessage="Invalid security code" ValidationGroup="valid" ValidationExpression="^\d{3}$"></asp:RegularExpressionValidator>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="btnPurchase" runat="server" CssClass="purchaseButton" Text="Complete Order" OnClick="btnPurchase_Click" />
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
