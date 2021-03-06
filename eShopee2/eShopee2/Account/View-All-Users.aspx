<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View-All-Users.aspx.cs" Inherits="eShopee2.Account.View_All_Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>User Management</h2>
    <asp:Panel ID="pnlUser" runat="server"></asp:Panel>
    <asp:DataGrid ID="grid" runat="server" DataSourceID="User" Height="136px"
        HorizontalAlign="Justify" oncancelcommand="cancel" oneditcommand="edit"
        onselectedindexchanged="grid_SelectedIndexChanged"
        onupdatecommand="grid_UpdateCommand" Width="840px">
        <Columns>
            <asp:EditCommandColumn CancelText="Cancel" EditText="Edit" UpdateText="Update">
            </asp:EditCommandColumn>
        </Columns>
        <HeaderStyle BorderStyle="None" ForeColor="Black" HorizontalAlign="Center"
            VerticalAlign="Middle" />
        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
    </asp:DataGrid>
<asp:SqlDataSource ID="User" runat="server"
    ConnectionString="<%$ ConnectionStrings:userstring %>"

        SelectCommand="SELECT [name], [mobile], [role], [status], [email] FROM [users]">
</asp:SqlDataSource>
</asp:Content>
 ck
