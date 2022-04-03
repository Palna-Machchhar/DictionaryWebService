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
        
        <table class="table table-hover" style="width:50%;">
            <tr>
                <td>Title</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr class="table-active">
                <td>Meaning</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr class="table-primary">
                <td>Pronunciation</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr class="table-secondary">
                <td class="auto-style1">Plural</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr class="table-success">
                <td class="auto-style1">Adjective</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr class="table-danger">
                <td>Synonym</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr class="table-warning">
                <td>Antonym</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr class="table-info">
                <td class="auto-style1">Example Sentence </td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style1" colspan="2">
                    <center><asp:Button class="btn btn-success" ID="Button1" runat="server" OnClick="Button1_Click"  Text="Button" />
                 </center>
                </td>
                
            </tr>
        </table>
              <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin.aspx">Back</asp:HyperLink>
            </div>
 </asp:Content>
