<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View-All-Products.aspx.cs" Inherits="eShopee2.Product.View_All_Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Product Management</h2>

    <asp:DataGrid ID="products" runat="server" DataSourceID="Productstable"
        Height="121px" Width="919px" Font-Bold="True" Font-Names="Arial Black"
        HorizontalAlign="Justify">
        <Columns>
            <asp:EditCommandColumn CancelText="Cancel" EditText="Edit" UpdateText="Update">
            </asp:EditCommandColumn>
        </Columns>
        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        <PagerStyle Font-Bold="False" HorizontalAlign="Justify" />
    </asp:DataGrid>
    <asp:SqlDataSource ID="Productstable" runat="server"
        ConnectionString="<%$ ConnectionStrings:userstring %>"
        SelectCommand="SELECT [ID], [name], [cost], [instock], [featured], [status] FROM [products]">
    </asp:SqlDataSource>
    <a href="Add-Product.aspx">Add Product</a>
    <asp:Panel ID="pnlProduct" runat="server"></asp:Panel>
</asp:Content> 
