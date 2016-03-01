<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit-Profile.aspx.cs" Inherits="eShopee2.Account.Edit_Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit Profile</h2>
    <asp:Literal ID="litError" runat="server"></asp:Literal>


    <asp:Image id="Image1" runat="server"
           AlternateText="Image text"
           ImageAlign="left" Height="174px" Width="202px"/>




    <table>
    <tr>

            <td><asp:FileUpload ID="fileImage" runat="server" /></td>
            <td><asp:Button ID="Button1" runat="server" Height="20px" onclick="Button1_Click"
                    Text="Update Picture" Width="128px" /></td>
        </tr>

        <tr>
            <td> <strong>&nbsp;Email Address</strong></td>
            <td><asp:Literal ID="litEmail" runat="server"></asp:Literal></td>
        </tr>
        <tr>
            <td>
                <strong>Name</strong></td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
            <td>
                <strong>Mobile</strong></td>
            <td><asp:TextBox ID="txtMobile" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <strong>Address</strong></td>
            <td><asp:TextBox ID="txtaddress" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnUpdate" runat="server" Text="Update"
                    onclick="btnUpdate_Click" /></td>
        </tr>
    </table>
</asp:Content>
 
