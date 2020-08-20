<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
            width: 798px;
        }
        .auto-style2 {
            width: 99%;
            height: 614px;
            margin-left: 7px;
        }
        .auto-style9 {
            width: 281px;
        }
        .auto-style10 {
            text-align: left;
            width: 547px;
        }
        .auto-style11 {
            width: 547px;
        }
        .auto-style12 {
            width: 138px;
        }
        .auto-style13 {
            text-align: right;
            width: 281px;
        }
        .auto-style14 {
            margin-left: 0px;
        }
        .auto-style15 {
            width: 138px;
            height: 30px;
        }
        .auto-style16 {
            width: 547px;
            height: 30px;
        }
        .auto-style17 {
            width: 281px;
            height: 30px;
        }
    </style>
</head>
<body style="width: 801px; height: 660px; margin-left: 95px; margin-right: 130px; margin-top: 79px; margin-bottom: 80px;">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Appointment Booking</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Menu ID="Menu1" runat="server">
                        <Items>
                            <asp:MenuItem NavigateUrl="WebForm3.aspx" Text="Appointment" Value="Appointment"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="WebForm6.aspx" Text="Records" Value="Records"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                </td>
                <td class="auto-style13">
                    <asp:Button ID="btnlogout" runat="server" OnClick="btnlogout_Click" Text="Logout" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="Label4" runat="server" Text="Doctor"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style13">
                    &nbsp;<asp:TextBox ID="txtusername" runat="server" ReadOnly="True" Width="198px" CssClass="auto-style14"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="Label5" runat="server" Text="Date"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="331px" >
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                        <TodayDayStyle BackColor="#CCCCCC" />
                    </asp:Calendar>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="Label6" runat="server" Text="Time"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button1" runat="server" Height="50px" Text="9 AM" Width="90px" BackColor="Red" Enabled="False" OnClick="Button1_Click" Visible="False" />
                    <asp:Button ID="Button2" runat="server" Text="10 AM" Height="50px" Width="90px" BackColor="Red" Enabled="False" OnClick="Button2_Click" Visible="False" />
                    <asp:Button ID="Button3" runat="server" Text="11 AM" Height="50px" Width="90px" BackColor="Red" Enabled="False" OnClick="Button3_Click" Visible="False" />
                    <asp:Button ID="Button4" runat="server" Text="12 PM" Height="50px" Width="90px" BackColor="Red" Enabled="False" Visible="False" OnClick="Button4_Click" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style11">
                    <asp:Button ID="Button5" runat="server" Text="2 PM" Height="50px" Width="90px" BackColor="Red" Enabled="False" Visible="False" OnClick="Button5_Click" />
                    <asp:Button ID="Button6" runat="server" Text="3 PM" Height="50px" Width="90px" BackColor="Red" Enabled="False" Visible="False" OnClick="Button6_Click" />
                    <asp:Button ID="Button7" runat="server" Text="4 PM" Height="50px" Width="90px" BackColor="Red" Enabled="False" Visible="False" OnClick="Button7_Click" />
                    <asp:Button ID="Button8" runat="server" Text="5 PM" Height="50px" Width="90px" BackColor="Red" Enabled="False" Visible="False" OnClick="Button8_Click" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">User selected</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtShow2" runat="server" Width="121px" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtShow" runat="server" Width="121px" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style16">
                    <asp:Button ID="btncheck" runat="server" Text="Check" Width="100px" OnClick="btncheck_Click" />
                    <asp:Button ID="btnbook" runat="server"  Text="Book" Width="100px" OnClick="btnbook_Click" />
                </td>
                <td class="auto-style17">
                    </td>
            </tr>
        </table>
    </form>
        </body>
</html>
