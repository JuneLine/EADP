<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DestinationUpdateForm.aspx.cs" Inherits="SREX.DestinationUpdateForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
            <div class="page-header well">
                <h1 class="text-center">Editing</h1>
            </div>
    </div>
    <table class="table">
        <asp:Label ID="LabelError" runat="server"></asp:Label>
            <tr>
                <td class="auto-style1">Destination name</td>
                <td>
                    <asp:Label ID="LbDestination" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Picture :</td>
                <td>
                    <div class="custom-file">
                         <asp:FileUpload runat="server" CssClass="custom-file-input" ID="FileLocation" />
                    </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Description :</td>
                <td>
                    <asp:TextBox ID="TbDescription" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                    <td class="auto-style1">Price :</td>
                    <td>
                        <asp:TextBox ID="TbPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
            <tr>
                    <td class="auto-style1">Tag :</td>
                    <td>
                        <asp:TextBox ID="TbTag" runat="server"></asp:TextBox>
                    </td>
                </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click"  />&nbsp;&nbsp;
                   <asp:Button ID="BtnBack" runat="server" OnClick="BtnBack_Click" Text="Back" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Label ID="LblResult" Text="" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
</asp:Content>
