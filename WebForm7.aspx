<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication2.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
            width: 295px;
            height: 80px;
        }
        .auto-style2 {
            width: 99%;
        }
        .auto-style3 {
            width: 209px;
        }
        .auto-style4 {
            width: 209px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
            width: 199px;
        }
        .auto-style7 {
            width: 199px;
        }
        .auto-style8 {
            height: 26px;
            width: 152px;
        }
        .auto-style9 {
            width: 152px;
        }
        .auto-style10 {
            height: 26px;
            width: 152px;
            text-align: right;
        }
    </style>
</head>
<body style="width: 732px; height: 1321px; margin-left: 127px; margin-right: 129px; margin-top: 82px; margin-bottom: 84px;">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            Diagnosis Form</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Logout" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="" title="">Angina</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" Text="Yes" OnCheckedChanged="RadioButton1_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1"  Text="No" OnCheckedChanged="RadioButton2_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="" title="">Bruise</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="2" OnCheckedChanged="RadioButton3_CheckedChanged" Text="Yes" />
                    <asp:RadioButton ID="RadioButton4" runat="server" GroupName="2" Text="No" OnCheckedChanged="RadioButton4_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Coughing up blood</td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton5" runat="server" GroupName="3" Text="Yes" OnCheckedChanged="RadioButton5_CheckedChanged1" />
                    <asp:RadioButton ID="RadioButton6" runat="server" GroupName="3" Text="No" OnCheckedChanged="RadioButton6_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Coughing</td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton7" runat="server" GroupName="4" OnCheckedChanged="RadioButton7_CheckedChanged" Text="Yes" />
                    <asp:RadioButton ID="RadioButton8" runat="server" GroupName="4" Text="No" OnCheckedChanged="RadioButton8_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Coma</td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton9" runat="server" GroupName="5" Text="Yes" OnCheckedChanged="RadioButton9_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton10" runat="server" GroupName="5" Text="No" OnCheckedChanged="RadioButton10_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="" title="">Dizzy</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton11" runat="server" GroupName="6" Text="Yes" OnCheckedChanged="RadioButton11_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton12" runat="server" GroupName="6" Text="No" OnCheckedChanged="RadioButton12_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">D<span class="tlid-translation translation" lang="en"><span title="">iarrhea</span></span></td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton13" runat="server" GroupName="7" Text="Yes" OnCheckedChanged="RadioButton13_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton14" runat="server" GroupName="7" Text="No" OnCheckedChanged="RadioButton14_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><span class="tlid-translation translation" lang="en"><span class="" title="">Difficulty breathing</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton15" runat="server" GroupName="8" Text="Yes" OnCheckedChanged="RadioButton15_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton16" runat="server" GroupName="8" Text="No" OnCheckedChanged="RadioButton16_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Flu</td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton17" runat="server" GroupName="9" Text="Yes" OnCheckedChanged="RadioButton17_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton18" runat="server" GroupName="9" Text="No" OnCheckedChanged="RadioButton18_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Foot pain</td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton19" runat="server" GroupName="10" Text="Yes" OnCheckedChanged="RadioButton19_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton20" runat="server" GroupName="10" Text="No" OnCheckedChanged="RadioButton20_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="auto-style3" title="">Genital pain</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton21" runat="server" GroupName="11" Text="Yes" OnCheckedChanged="RadioButton21_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton22" runat="server" GroupName="11" Text="No" OnCheckedChanged="RadioButton22_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Hand pain</td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton23" runat="server" GroupName="12" Text="Yes" OnCheckedChanged="RadioButton23_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton24" runat="server" GroupName="12" Text="No" OnCheckedChanged="RadioButton24_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">H<span class="tlid-translation translation" lang="en"><span class="" title="">eadache</span></span><span class="tlid-translation-gender-indicator translation-gender-indicator"></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton25" runat="server" GroupName="13" Text="Yes" OnCheckedChanged="RadioButton25_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton26" runat="server" GroupName="13" Text="No" OnCheckedChanged="RadioButton26_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">I<span class="tlid-translation translation" lang="en"><span class="" title="">tch</span></span></td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton27" runat="server" GroupName="14" Text="Yes" OnCheckedChanged="RadioButton27_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton28" runat="server" GroupName="14" Text="No" OnCheckedChanged="RadioButton28_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">I<span class="tlid-translation translation" lang="en"><span class="" title="">ncontinence</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton29" runat="server" GroupName="15" Text="Yes" OnCheckedChanged="RadioButton29_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton30" runat="server" GroupName="15" Text="No" OnCheckedChanged="RadioButton30_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="" title="">Irregular heart rate</span></span></td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton31" runat="server" GroupName="16" Text="Yes" OnCheckedChanged="RadioButton31_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton32" runat="server" GroupName="16" Text="No" OnCheckedChanged="RadioButton32_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Muscle pain</td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton33" runat="server" GroupName="17" Text="Yes" OnCheckedChanged="RadioButton33_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton34" runat="server" GroupName="17" Text="No" OnCheckedChanged="RadioButton34_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Mouth ulcer</td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton35" runat="server" GroupName="18" Text="Yes" OnCheckedChanged="RadioButton35_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton36" runat="server" GroupName="18" Text="No" OnCheckedChanged="RadioButton36_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="auto-style3" title="" dir="ltr">Rash</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton37" runat="server" GroupName="19" Text="Yes" OnCheckedChanged="RadioButton37_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton38" runat="server" GroupName="19" Text="No" OnCheckedChanged="RadioButton38_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">R<span class="tlid-translation translation" lang="en"><span class="" title="">igid muscles</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton39" runat="server" GroupName="20" Text="Yes" OnCheckedChanged="RadioButton39_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton40" runat="server" GroupName="20" Text="No" OnCheckedChanged="RadioButton40_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="auto-style3" title="">Runny nose</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton41" runat="server" GroupName="21" Text="Yes" OnCheckedChanged="RadioButton41_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton42" runat="server" GroupName="21" Text="No" OnCheckedChanged="RadioButton42_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="" title="">Shoulder pain</span></span></td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton43" runat="server" GroupName="22" Text="Yes" OnCheckedChanged="RadioButton43_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton44" runat="server" GroupName="22" Text="No" OnCheckedChanged="RadioButton44_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">S<span class="tlid-translation translation" lang="en"><span class="" title="">tomachache</span></span></td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton45" runat="server" GroupName="23" Text="Yes" OnCheckedChanged="RadioButton45_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton46" runat="server" GroupName="23" Text="No" OnCheckedChanged="RadioButton46_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="" title="">Sore throat</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton47" runat="server" GroupName="24" Text="Yes" OnCheckedChanged="RadioButton47_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton48" runat="server" GroupName="24" Text="No" OnCheckedChanged="RadioButton48_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">S<span class="tlid-translation translation" lang="en"><span class="" title="">putum</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton49" runat="server" GroupName="25" Text="Yes" OnCheckedChanged="RadioButton49_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton50" runat="server" GroupName="25" Text="No" OnCheckedChanged="RadioButton50_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Sneezing</td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton51" runat="server" GroupName="26" Text="Yes" OnCheckedChanged="RadioButton51_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton52" runat="server" GroupName="26" Text="No" OnCheckedChanged="RadioButton52_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="" title="">Toothache</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton53" runat="server" GroupName="27" Text="Yes" OnCheckedChanged="RadioButton53_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton54" runat="server" GroupName="27" Text="No" OnCheckedChanged="RadioButton54_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">T<span class="tlid-translation translation" lang="en"><span class="" title="">innitus</span></span></td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton55" runat="server" GroupName="28" Text="Yes" OnCheckedChanged="RadioButton55_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton56" runat="server" GroupName="28" Text="No" OnCheckedChanged="RadioButton56_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="" title="">Urethral pain</span></span></td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton57" runat="server" GroupName="29" Text="Yes" OnCheckedChanged="RadioButton57_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton58" runat="server" GroupName="29" Text="No" OnCheckedChanged="RadioButton58_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="tlid-translation translation" lang="en"><span class="" title="">Vomiting blood</span></span></td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton59" runat="server" GroupName="30" Text="Yes" OnCheckedChanged="RadioButton59_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton60" runat="server" GroupName="30" Text="No" OnCheckedChanged="RadioButton60_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Class</td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton61" runat="server" GroupName="31" Text="Yes" OnCheckedChanged="RadioButton61_CheckedChanged" />
                    <asp:RadioButton ID="RadioButton62" runat="server" GroupName="31" Text="No" OnCheckedChanged="RadioButton62_CheckedChanged" Checked="True" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Reasonings</td>
                <td class="auto-style7">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>Diabetes</asp:ListItem>
                        <asp:ListItem>HighBloodPressure</asp:ListItem>
                        <asp:ListItem>PeriodontalDisease</asp:ListItem>
                        <asp:ListItem>HeartDisease</asp:ListItem>
                        <asp:ListItem>Sensitive</asp:ListItem>
                        <asp:ListItem>Cancer</asp:ListItem>
                        <asp:ListItem>Fever</asp:ListItem>
                        <asp:ListItem Value="Others">Covid-19</asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                        <asp:ListItem>Healthy</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
                    &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
