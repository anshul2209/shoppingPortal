<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View-Profile.aspx.cs" Inherits="eShopee2.Account.View_Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 184px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>View Profile</h2>

    <asp:Image ID="pnlimg" runat="server" Height="174px" Width="245px"/>
    <table>
     <tr>
            <td class="style1">Name</td>
            <td><asp:Literal ID="litName" runat="server"></asp:Literal></td>
      </tr>
        <tr>
            <td class="style1">Email Address</td>
            <td><asp:Literal ID="litEmail" runat="server"></asp:Literal></td>
        </tr>
        <tr>
            <td class="style1">Address</td>
            <td><asp:Literal ID="Litaddress" runat="server"></asp:Literal></td>
        </tr>
        <tr>
            <td class="style1">Mobile</td>
            <td><asp:Literal ID="litMobile" runat="server"></asp:Literal></td>
        </tr>
    </table>
</asp:Content>
 nt
