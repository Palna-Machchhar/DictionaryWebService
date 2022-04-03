<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="DictionaryClient.Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title></title>
 </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>

        <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_OnRowCommand" AutoGenerateColumns="false" Width="80%">
            <Columns>
                <asp:BoundField DataField="WordId" HeaderText="WordId" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="0.3%" />
                <asp:BoundField DataField="Title" HeaderText="Title" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="0.3%" />
                <asp:BoundField DataField="Meaning" HeaderText="Meaning" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="0.3%" />
                <asp:BoundField DataField="Pronunciation" HeaderText="Pronunciation" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="0.3%" />
                <asp:BoundField DataField="Plural" HeaderText="Plural" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="0.3%"  />
                <asp:BoundField DataField="Adjective" HeaderText="Adjective" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="0.3%"  />
                <asp:BoundField DataField="Synonym" HeaderText="Synonym" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="0.3%"  />
                <asp:BoundField DataField="Antonym" HeaderText="Antonym" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="0.3%" />
                <asp:BoundField DataField="ExampleSentence" HeaderText="ExampleSentence" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="0.3%" />
                <asp:TemplateField HeaderText="Action" ItemStyle-Width="3%"  >    
                    <ItemTemplate>
                    <asp:LinkButton class="btn btn-primary" ID="ebutton"  runat="server" CommandArgument='<%#Eval("WordId") %>' CommandName="EditWord" Text="Edit" />
                    <asp:LinkButton class="btn btn-danger" ID="dbutton"   runat="server" CommandName="DeleteWord"  CommandArgument='<%#Eval("WordId") %>' OnClientClick='return confirm("Are you sure you want to delete ?");' Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            <br /><br />
        <asp:Button ID="Button1" class="btn btn-success" runat="server" OnClick="Button1_Click" Text="Add Word" />
        <br />
        </div>
     </asp:Content>
