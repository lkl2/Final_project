<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="WebApplication2.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
            width: 428px;
        }
        .auto-style2 {
            width: 150px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 150px;
            text-align: center;
        }
    </style>
</head>
<body style="width: 581px; margin-left: 130px; margin-right: 133px; margin-top: 79px; margin-bottom: 79px; height: 162px;">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Reset Password</strong></div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Enter your email</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3" Width="199px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Reset password link have been sent to your email!" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Reset" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Login" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
