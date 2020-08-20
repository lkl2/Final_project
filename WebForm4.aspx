<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication2.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
            width: 384px;
            height: 71px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 88px;
        }
    </style>
</head>
<body style="width: 500px; height: 218px; margin-left: 130px; margin-top: 80px; margin-right: 130px; margin-bottom: 79px;">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Admin Login Form</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Username</td>
                <td>
                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtusername" Display="Dynamic" ErrorMessage="*Username is required!" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td>
                    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" Display="Dynamic" ErrorMessage="*Password is required!" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    &nbsp;</td>
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
