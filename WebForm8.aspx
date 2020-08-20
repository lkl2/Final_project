<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication2.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style4 {
            width: 200px;
            height: 20px;
        }
        .auto-style16 {
            font-size: large;
        }
        .auto-style32 {
            height: 71px;
            width: 453px;
            font-size: large;
            text-align: center;
            margin-left: 150px;
            margin-right: 3px;
            margin-top: 50px;
        }
        .auto-style33 {
            height: 1840px;
            width: 776px;
            font-size: large;
            margin-left: 150px;
            margin-right: 150px;
            margin-top: 0px;
            margin-bottom: 79px;
        }
        .auto-style42 {
            font-size: small;
            text-align: center;
            width: 55px;
        }
        .auto-style43 {
            height: 50px;
            width: 55px;
            font-size: large;
        }
        .auto-style47 {
            height: 50px;
            width: 204px;
            font-size: large;
        }
        .auto-style48 {
            height: 50px;
            width: 300px;
            font-size: large;
        }
        .auto-style49 {
            height: 50px;
            width: 300px;
            font-size: large;
            text-align: center;
        }
        .auto-style50 {
            height: 50px;
            width: 204px;
            font-size: large;
            text-align: right;
        }
        .auto-style51 {
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style51">
        <div class="auto-style1">
            <div class="auto-style32">
                <strong>
                <span class="auto-style1">Diagnose Data</span></strong></div>
        </div>
            <table class="auto-style33">
                <tr>
                <td class="auto-style48">
                    <asp:Menu ID="Menu2" runat="server">
                        <Items>
                            <asp:MenuItem NavigateUrl="WebForm5.aspx" Text="Appointments Manage" Value="Appointments Manage"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="WebForm14.aspx" Text="Doctors Manage" Value="Doctors Manage"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="WebForm8.aspx" Text="Diagnoses Manage" Value="Diagnoses Manage"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                    </td>
                    <td class="auto-style43">
                        &nbsp;</td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style50">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
                        <asp:TextBox ID="TextBox38" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                <td class="auto-style48">
                <strong>
                        <asp:TextBox ID="TextBox37" runat="server"></asp:TextBox>
                        </strong></td>
                    <td class="auto-style43">
                <strong>
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="80px" >
                        </asp:DropDownList>
                        </strong>
                    </td>
                    <td class="auto-style48">
                <strong>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View" />
                        </strong>
                    </td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style49">
                <strong>
                    <asp:TextBox ID="TextBox33" runat="server" MaxLength="2" Width="30px"></asp:TextBox>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem Value="January">Jan</asp:ListItem>
                        <asp:ListItem Value="February">Feb</asp:ListItem>
                        <asp:ListItem Value="March">Mar</asp:ListItem>
                        <asp:ListItem Value="April">Apr</asp:ListItem>
                        <asp:ListItem>May</asp:ListItem>
                        <asp:ListItem Value="June">Jun</asp:ListItem>
                        <asp:ListItem>July</asp:ListItem>
                        <asp:ListItem Value="August">Aug</asp:ListItem>
                        <asp:ListItem Value="September">Sep</asp:ListItem>
                        <asp:ListItem Value="October">Oct</asp:ListItem>
                        <asp:ListItem Value="November">Nov</asp:ListItem>
                        <asp:ListItem Value="December">Dec</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="TextBox34" runat="server" MaxLength="4" Width="50px"></asp:TextBox>
                    </strong></td>
                    <td class="auto-style42">
                        To</td>
                    <td class="auto-style49">
                <strong>
                        <asp:TextBox ID="TextBox35" runat="server" MaxLength="2" Width="30px"></asp:TextBox>
                        <asp:DropDownList ID="DropDownList3" runat="server">
                            <asp:ListItem Value="January">Jan</asp:ListItem>
                            <asp:ListItem Value="Febuary">Feb</asp:ListItem>
                            <asp:ListItem Value="March">Mar</asp:ListItem>
                            <asp:ListItem Value="April">Apr</asp:ListItem>
                            <asp:ListItem>May</asp:ListItem>
                            <asp:ListItem Value="June">Jun</asp:ListItem>
                            <asp:ListItem>July</asp:ListItem>
                            <asp:ListItem Value="August">Aug</asp:ListItem>
                            <asp:ListItem Value="September">Sep</asp:ListItem>
                            <asp:ListItem Value="October">Oct</asp:ListItem>
                            <asp:ListItem Value="November">Nov</asp:ListItem>
                            <asp:ListItem Value="December">Dec</asp:ListItem>
                        </asp:DropDownList>
                        <asp:TextBox ID="TextBox36" runat="server" MaxLength="4" Width="51px"></asp:TextBox>
                        </strong>
                    </td>
                    <td class="auto-style47">
                <strong>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Export" />
                        </strong>
                    </td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Angina</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="180px" />
                        </td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Bruise</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        <asp:DropDownList ID="DropDownList4" runat="server">
                            <asp:ListItem>J48</asp:ListItem>
                            <asp:ListItem>MLP</asp:ListItem>
                            <asp:ListItem>NaiveBayes</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                </tr>
                <tr>
                <td class="auto-style48">Coughing up blood</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="FileUpload1" ErrorMessage="#only arff file" Font-Size="Small" ForeColor="Red" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))(.arff|.ARFF)$" ClientIDMode="AutoID" Display="Dynamic"></asp:RegularExpressionValidator>
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Weka" />
                    </td>
                </tr>
                <tr>
                <td class="auto-style48">Coughing</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        </td>
                    <td class="auto-style47">
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                        </td>
                </tr>
                <tr>
                <td class="auto-style48">Coma</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Dizzy</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">D<span class="tlid-translation translation" lang="en"><span title="">iarrhea</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Difficulty breathing</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox8" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">Flu</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox9" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">Foot pain</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox10" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Genital pain</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox11" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">Hand pain</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox12" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">H<span class="tlid-translation translation" lang="en"><span class="" title="">eadache</span></span><span class="tlid-translation-gender-indicator translation-gender-indicator"></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox13" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">I<span class="tlid-translation translation" lang="en"><span class="" title="">tch</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox14" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">I<span class="tlid-translation translation" lang="en"><span class="" title="">ncontinence</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox15" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Irregular heart rate</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox16" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">Muscle pain</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox17" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">Mouth ulcer</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox18" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="auto-style4" title="" dir="ltr">Rash</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox19" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">R<span class="tlid-translation translation" lang="en"><span class="" title="">igid muscles</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox20" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Runny nose</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox21" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Shoulder pain</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox22" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">S<span class="tlid-translation translation" lang="en"><span class="" title="">tomachache</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox23" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Sore throat</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox24" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">S<span class="tlid-translation translation" lang="en"><span class="" title="">putum</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox25" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">Sneezing</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox26" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Toothache</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox27" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">T<span class="tlid-translation translation" lang="en"><span class="" title="">innitus</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox28" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Urethral pain</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox29" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48"><span class="tlid-translation translation" lang="en"><span class="" title="">Vomiting blood</span></span></td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox30" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">Class</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox31" runat="server" CssClass="auto-style16" Width="50px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style48">Reasoning</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="TextBox32" runat="server" CssClass="auto-style16" Width="100px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                </tr>
                </table>
    </form>
</body>
</html>
