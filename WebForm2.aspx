<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
            width: 499px;
            height: 72px;
        }
        .auto-style2 {
            width: 99%;
            height: 594px;
            margin-right: 95px;
            margin-left: 5px;
        }
        .auto-style3 {
            width: 88px;
        }
        .auto-style4 {
            width: 88px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
            width: 551px;
        }
        .auto-style8 {
            width: 551px;
        }
        .auto-style11 {
            width: 88px;
            height: 24px;
        }
        .auto-style12 {
            height: 24px;
            width: 551px;
        }
    </style>
</head>
<body style="width: 505px; height: 663px; margin-left: 130px; margin-right: 131px; margin-top: 80px; margin-bottom: 80px;">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            Registration Form</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style11">Email</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtemail" runat="server" placeholder="example123@hotmail.com" Width="198px" MaxLength="40"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtemail" Display="Dynamic" ErrorMessage="*Email is required." Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style12">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtpassword" runat="server" placeholder="************" TextMode="Password" Width="198px" MaxLength="12"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" Display="Dynamic" ErrorMessage="*Password is required." Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Full Name</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtfullname" runat="server" placeholder="Steven Ng" Width="198px" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtfullname" Display="Dynamic" ErrorMessage="*Fullname is required." Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Gender</td>
                <td class="auto-style8">
                    <asp:DropDownList ID="dropdownlistgender" runat="server">
                        <asp:ListItem Value="male">Male</asp:ListItem>
                        <asp:ListItem Value="female">Female</asp:ListItem>
                        <asp:ListItem Value="other">Other</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">IC</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtic" runat="server" placeholder="010203-04-0506" Width="198px" MaxLength="12"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtic" Display="Dynamic" ErrorMessage="*IC is required." Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Address</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtaddress" runat="server" placeholder="54, Jalan Sultan Ahmad Shah, 10050 George Town, Pulau Pinang" Width="198px" Height="100px" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtaddress" Display="Dynamic" ErrorMessage="*Address is required." Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style8">
                    Already member?<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="WebForm1.aspx">Login</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Button ID="btnregister" runat="server" Text="Register" Width="100px" OnClick="btnregister_Click"  />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
