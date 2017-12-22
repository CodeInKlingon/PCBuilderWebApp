<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="WebApplication.Checkout" Theme="LabelSkin1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Checkout
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h2>Checkout</h2>
    <hr style=" border-top: 1px dashed black;" class="inner" />
    <table style="width: 25%;">
        <tr>
            <td style="height: 25px"><h3>Subtotal:</h3></td>
            <td style="height: 25px"><h3>Total:</h3></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    &nbsp;Have a coupon?<br>
    &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Apply Coupon" Height="20px" Width="100px" />
</asp:Content>
