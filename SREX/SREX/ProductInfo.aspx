<%@ Page Title="Product Info" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductInfo.aspx.cs" Inherits="SREX.ProductInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Product.css" rel="stylesheet" />
    <div id="showMessage" runat="server" role="alert">
        <asp:Label runat="server" ID="AddMessage"></asp:Label>
    </div>

    <div class="row body-container-own" style="margin-top: 50px;">
        <div class="col-lg-5 col-md-6 col-sm-12 center-block">
            <asp:Image runat="server" class="img-responsive" ID="productImage" Style="width: 260px; margin-left: auto; margin-right: auto;"></asp:Image>
        </div>

        <div class="col-lg-7 col-md-6 col-sm-12" id="MyText">
            <asp:Label runat="server" ID="lbName"></asp:Label>
            <br />
            <asp:Label runat="server" ID="lbStock"></asp:Label>
            <br />
            <br />
            Price:
            <asp:Label runat="server" ID="lbPrice"></asp:Label>
            <br />
            <br />
            <%--Size: <span style="font-weight: bold">55 Inch</span>
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True">55 Inch &nbsp&nbsp</asp:ListItem>
                <asp:ListItem>60 Inch &nbsp&nbsp</asp:ListItem>
                <asp:ListItem>65 Inch</asp:ListItem>
            </asp:RadioButtonList>
            <br />--%>
            <ul>
                <asp:Label runat="server" ID="lbDescription"></asp:Label>
            </ul>
            <div style="float: right; margin-right: 160px; margin-top: 30px;">
                <asp:Button ID="ButtonBuyNow" CssClass="btn btn-primary" runat="server" Text="Add to Cart" OnClick="BTAddToCart_Click" />
            </div>
            <div style="float: right; margin-right: 20px;">
                <h6>Quantity:</h6>
                <asp:TextBox type="number" ID="quantityTb" runat="server" min="1" max="50" class="form-control text-center quantity" value="1"></asp:TextBox>
            </div>
            <div style="float: right; margin-right: 160px; margin-top: 30px;">
                <asp:Button ID="ButtonInfo" Type="button" Style="display: none" CssClass="btn btn-info" runat="server" Text="Edit" OnClick="ButtonEdit_Click" />
            </div>
        </div>
    </div>

</asp:Content>
