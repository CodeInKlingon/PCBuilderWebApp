<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment02.MasterPage" %>

<!DOCTYPE html>
<link href="myStylesheet.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Homepage</title>
    <style type="text/css">
        #AdBlock {
            height: 64px;
        }
    </style>
</head>
<body style="margin-left: 100px; margin-right: 100px; margin-top: 10px">
    <form id="form1" runat="server">
    <div style="width:800px; height: 800px">
    <header>
        <asp:Image ID="ImageLogo" runat="server" Height="137px" ImageUrl="~/Images/Logo.jpg" Width="789px" />
        <div id="Nav">
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home" Value="Home"></asp:MenuItem>
                    <asp:MenuItem Text="Catergies" Value="Catergies">
                        <asp:MenuItem Text="  BuildPC" Value="BuildPC" />
                        <asp:MenuItem Text="  Searchparts" Value="Searchparts" />
                    </asp:MenuItem>
                    <asp:MenuItem Text="Forums" Value="Forums"></asp:MenuItem>
                    <asp:MenuItem Text="Aboutus" Value="Aboutus"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </header>

        <div id="Middleblock" style="background-color:blue">
            <div id="Left" style="float:left; width: 450px; height: 500px">
                
                <asp:Panel ID="PanelTop" runat="server" style="margin-top:40px; margin-left: 5px">
                    <asp:Label ID="LblCalendar" runat="server" Text="Choice a day in the Calendar" />
                    <br />
                    <br />
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="160px" ImageUrl="~/Images/VideoCardZotacGeForce.jpg" Width="244px" />
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server">Zotac GeForce GTX 1060 </asp:HyperLink>
                </asp:Panel>
                <asp:Panel ID="PenalBot" runat="server" style="margin-top: 10px; color:black; background-color: white; font-size: 24px">
                    <asp:Literal ID="Literal1" runat="server">Welcome customer to the website. View what type of PC parts that is on sale.</asp:Literal>

                </asp:Panel>
            </div>
            <div id="Right" style="float:right; width:350px; height: 500px">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px" OnSelectionChanged="Calendar1_SelectionChanged" style="margin-left: 12px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                    <DayStyle BackColor="#CCCCCC" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                    <TodayDayStyle BackColor="#999999" ForeColor="White" />
                </asp:Calendar>              

                <div id="AdBlock" style="margin-left: 4px; margin-top: 4px">
                    <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="Ads.xml" style="padding: 5px;"/>
                </div>
            </div>
        </div>
    <footer style="font-size: 6px; margin-bottom:auto" >

        <asp:Label ID="Copyright" runat="server" Text="Copyright | COMP229 Web Application design | Brandon Koo | 300794094"></asp:Label>

    </footer>
    </div>
    </form>
</body>
</html>
