<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
            width: 388px;
            margin-left: 1px;
            height: 70px;
        }
        .auto-style2 {
            width: 100%;
            height: 122px;
        }
        .auto-style3 {
            width: 100px;
        }
        .auto-style4 {
            width: 493px;
        }
    </style>
</head>
<body style="width: 500px; margin-left: 130px; margin-right: 130px; margin-top: 80px; margin-bottom: 81px; height: 248px;">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            Login Form</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">Email</td>
                <td class="auto-style4">
                    <asp:TextBox ID="textbox1" runat="server" Width="198px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textbox1" Display="Dynamic" ErrorMessage="*Email is required." Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="textbox2" runat="server" TextMode="Password" Width="198px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textbox2" Display="Dynamic" ErrorMessage="*Password is required." Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    Not a member yet? <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="WebForm2.aspx">Register now!</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="WebForm10.aspx">Reset Password</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" Text="Login" Width="100px" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>



