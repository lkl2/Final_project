<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm13.aspx.cs" Inherits="WebApplication2.WebForm13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            width: 348px;
            text-align: center;
        }
        .auto-style2 {
            width: 99%;
            margin-left: 0px;
        }
        .auto-style3 {
            width: 100px;
        }
    </style>
</head>
<body style="width: 477px; margin-left: 130px; margin-right: 130px; margin-top: 80px; height: 195px; margin-bottom: 81px;">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Doctor Login Form</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Username</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
