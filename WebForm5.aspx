<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication2.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
            width: 538px;
            height: 70px;
        }
        .auto-style2 {
            width: 98%;
            height: 289px;
        }
        .auto-style5 {
            text-align: right;
            width: 247px;
        }
        .auto-style6 {
            width: 247px;
        }
        .auto-style7 {
            width: 88px;
        }
        .auto-style8 {
            text-align: left;
            width: 368px;
        }
        .auto-style9 {
            width: 368px;
        }
    </style>
</head>
<body style="margin: 80px 130px; width: 610px; height: 551px; ">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Appointment Manage Form</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Menu ID="Menu2" runat="server">
                        <Items>
                            <asp:MenuItem NavigateUrl="WebForm5.aspx" Text="Appointments Manage" Value="Appointments Manage"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="WebForm14.aspx" Text="Doctors Manage" Value="Doctors Manage"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="WebForm8.aspx" Text="Diagnoses Manage" Value="Diagnoses Manage"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                </td>
                <td class="auto-style5">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Doctor</td>
                <td class="auto-style9">
                    <asp:DropDownList ID="DropDownList1" runat="server" >
                    </asp:DropDownList>
                </td>
                <td class="auto-style5">
                    Admin&nbsp; <asp:TextBox ID="txtadminname" runat="server" ReadOnly="True" Width="100px" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Date</td>
                <td class="auto-style9">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                        <TodayDayStyle BackColor="#CCCCCC" />
                    </asp:Calendar>
                </td>
                <td class="auto-style6">
                    Note that:
                    <br />
                    Morning(9am,10am,11am,12pm) and Afternoon(2pm,3pm,4pm,5pm)<br />
                    </td>
            </tr>
            <tr>
                <td class="auto-style7">Time</td>
                <td class="auto-style9">
                    <asp:CheckBox ID="checkboxmorning" runat="server" Text="Morning" OnCheckedChanged="checkboxmorning_CheckedChanged" />
                    <asp:CheckBox ID="checkboxafternoon" runat="server" Text="Afternoon" OnCheckedChanged="checkboxafternoon_CheckedChanged" />
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Button ID="Button4" runat="server" Height="40px" Text="9AM" Width="50px" Visible="False" OnClick="Button4_Click" />
                    <asp:Button ID="Button5" runat="server" Height="40px" Text="10AM" Width="50px" Visible="False" OnClick="Button5_Click" />
                    <asp:Button ID="Button6" runat="server" Height="40px" Text="11AM" Width="50px" Visible="False" OnClick="Button6_Click" />
                    <asp:Button ID="Button7" runat="server" Height="40px" Text="12PM" Width="50px" Visible="False" OnClick="Button7_Click" />
                </td>
                <td class="auto-style6">
                    remark:<br />
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Button ID="Button8" runat="server" Height="40px" Text="2PM" Width="50px" Visible="False" OnClick="Button8_Click" />
                    <asp:Button ID="Button9" runat="server" Height="40px" Text="3PM" Width="50px" Visible="False" OnClick="Button9_Click" />
                    <asp:Button ID="Button10" runat="server" Height="40px" Text="4PM" Width="50px" Visible="False" OnClick="Button10_Click" />
                    <asp:Button ID="Button11" runat="server" Height="40px" Text="5PM" Width="50px" Visible="False" OnClick="Button11_Click" />
                </td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create" OnClientClick="return confirm('Confirm?')"/>
                    <asp:Button ID="Button2" runat="server" Text="Retrieve" OnClick="Button2_Click" />
                    <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click"  />
                </td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
