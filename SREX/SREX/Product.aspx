<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="SREX.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Product.css" rel="stylesheet" />
    <div class="container">
        <div class="row" style="margin-top:50px;">
            <div class="col-lg-1">

            </div>
            <div class="col-lg-4">
                <img src="Pictures/model-1.jpg" style="height:300px;width:180px"/>
            </div>
            <div class="col-lg-7">
                Product Name: Clothes
                <br />
                Size:
                <br />
                <asp:Button ID="ButtonSmall" runat="server" Text="Small" class="OptionButton"/><asp:Button ID="ButtonMedium" runat="server" Text="Medium" class="OptionButton"/><asp:Button ID="ButtonLarge" runat="server" Text="Large" class="OptionButton"/>
                <br />
                Color:
                <br />
                <asp:Button ID="ButtonBlack" runat="server" Text="Black" class="OptionButton"/><asp:Button ID="ButtonWhite" runat="server" Text="White" class="OptionButton"/>
            </div>
        </div>
    </div>
</asp:Content>
