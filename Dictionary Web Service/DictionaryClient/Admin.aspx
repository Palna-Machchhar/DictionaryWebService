<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="DictionaryClient.Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title></title>
 </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>

        <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_OnRowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                    <asp:LinkButton ID="ebutton"  runat="server" CommandArgument='<%#Eval("WordId") %>' CommandName="EditWord" Text="Edit" />
                    <asp:LinkButton ID="dbutton"   runat="server" CommandName="DeleteWord"  CommandArgument='<%#Eval("WordId") %>' OnClientClick='return confirm("Are you sure you want to delete ?");' Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Word" />
        <br />
        </div>
     </asp:Content>
