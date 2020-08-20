<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication2.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
            width: 618px;
        }
        .auto-style2 {
            width: 100%;
            height: 314px;
        }
        .auto-style3 {
            width: 78px;
        }
        .auto-style5 {
            width: 202px;
        }
        .auto-style6 {
            width: 204px;
        }
        .auto-style7 {
            width: 619px;
            height: 357px;
        }
        .auto-style8 {
            width: 202px;
            text-align: right;
        }
    </style>
</head>
<body style="width: 622px; height: 363px; margin-left: 130px; margin-right: 128px; margin-bottom: 80px; margin-top: 79px;">
    <form id="form1" runat="server" class="auto-style7">
        <div class="auto-style1">
            <strong>My Records</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="btnlogout" runat="server" OnClick="btnlogout_Click" Text="Logout" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Menu ID="Menu1" runat="server">
                        <Items>
                            <asp:MenuItem NavigateUrl="WebForm3.aspx" Text="Appointment" Value="Appointment"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="WebForm6.aspx" Text="Records" Value="Records"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                </td>
                <td class="auto-style5"><asp:TextBox ID="txtusername" runat="server"  Width="190px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Created</td>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Doctor</td>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Date</td>
                <td class="auto-style6">
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Time</td>
                <td class="auto-style6">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList1" runat="server" >
                    </asp:DropDownList>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View" Width="80px" />
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
