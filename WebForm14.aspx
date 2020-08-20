<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm14.aspx.cs" Inherits="WebApplication2.WebForm14" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            width: 432px;
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
            height: 88px;
        }
        .auto-style4 {
            width: 75px;
        }
        .auto-style5 {
            width: 208px;
        }
        .auto-style6 {
            width: 375px;
        }
        .auto-style7 {
            width: 208px;
            text-align: right;
        }
    </style>
</head>
<body style="width: 745px; height: 318px; margin: 80px 130px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Manage Doctor Form</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style7">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Menu ID="Menu2" runat="server">
                        <Items>
                            <asp:MenuItem NavigateUrl="WebForm5.aspx" Text="Appointments Manage" Value="Appointments Manage"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="WebForm14.aspx" Text="Doctors Manage" Value="Doctors Manage"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="WebForm8.aspx" Text="Diagnoses Manage" Value="Diagnoses Manage"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Username</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Fullname</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View" Width="48px" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add" Width="48px" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" Width="58px" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Update" Width="58px" />
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Clear" Width="53px" />
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
