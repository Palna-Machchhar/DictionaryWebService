<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManageWord.aspx.cs" Inherits="DictionaryClient.ManageWord" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            margin-left: 40px;
        }
    </style>
 </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>Title</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Meaning</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Pronunciation</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Plural</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style1">Adjective</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>Synonym</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Antonym</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Example Sentence </td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"  Text="Button" />
&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin.aspx">Back</asp:HyperLink>
                </td>
            </tr>
        </table>
 </asp:Content>
