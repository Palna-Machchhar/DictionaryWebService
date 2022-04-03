<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DictionaryClient.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }

        .auto-style2 {
            margin-left: 40px;
            width: 204px;
        }

        .auto-style3 {
            height: 26px;
            width: 204px;
        }

        .auto-style8 {
            width: 204px;
            height: 24px;
        }

        .auto-style9 {
            height: 26px;
            width: 209px;
        }

        .auto-style10 {
            width: 209px;
            height: 24px;
        }

        .auto-style11 {
            width: 209px;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>
        <asp:TextBox ID="TextBox1" runat="server" Height="38px" Width="490px" placeholder="Search Here"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        <br />
        <br />
        <br />
        <% if (flag)
                { %>
        <table class="table table-hover" style="width: 50%;">
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Title</td>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr class="table-active">
                <td class="auto-style9">Meaning</td>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
            <tr class="table-primary">
                <td class="auto-style10">Pronunciation</td>
                <td class="auto-style8">
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr class="table-secondary">
                <td class="auto-style9">Plural</td>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
            </tr>
            <tr class="table-success">
                <td class="auto-style9">Adjective</td>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                </td>
            </tr>
            <tr class="table-danger">
                <td class="auto-style11">Synonym</td>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                </td>
            </tr>
            <tr class="table-warning">
                <td class="auto-style11">Antonym</td>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server"></asp:Label>
                </td>
            </tr>
            <tr class="table-info">
                <td class="auto-style9">Example Sentence </td>
                <td class="auto-style3">
                    <asp:Label ID="Label9" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <% }%>
    </div>

</asp:Content>
