<%@ Page Title="Product Info" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductInfo.aspx.cs" Inherits="SREX.ProductInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        var scroll = 0
        window.onload = function () {
            scroll = document.getElementById("MyText").clientHeight;
        }
        $(window).scroll(function () {
            var Windowscroll = $(window).scrollTop();
            if (Windowscroll + ($(window).height() / 2.5) <= scroll) {
                $(".MyPicture").addClass("FixedPicture");
                $(".MyPicture").css("margin-top", "");
            }
            else if (Windowscroll + ($(window).height() / 2.5) >= scroll) {
                $(".MyPicture").removeClass("FixedPicture");
                $(".MyPicture").css("margin-top", $("#MyText").height() / 2);
            }
            else {
                $(".MyPicture").addClass("FixedPicture");
                $(".MyPicture").css("margin-top", "");
            }
        });
    </script>
    <link href="Content/Product.css" rel="stylesheet" />
    <div class="row body-container-own" style="margin-top: 50px;">
        <div class="col-lg-5 col-md-6 col-sm-12 center-block">
            <%--<img src="https://images-na.ssl-images-amazon.com/images/I/91mqp0z-TiL._SX679_.jpg" class="ProductImage"/>--%>
            <%--<img src="Pictures/model-2.jpg" class="ProductImage" />--%>
            <img src="https://images-na.ssl-images-amazon.com/images/I/61Z5%2B%2BUWAbL._AC_UY695_.jpg" class="ProductImage MyPicture" />
        </div>
        
        <div class="col-lg-7 col-md-6 col-sm-12" id="MyText">
            <asp:Label runat="server" ID="lbName"></asp:Label>
           <%-- <span style="font-size: 21px;"><%#Eval("Name") %></span>--%>
            <br />
            <span style="color: green; font-size: 15px;">In Stock</span>
            <br />
            <br />
            Price: <span style="color: darkred">S$<%#Eval("Price") %></span>
            <br />
            <br />
            Size: <span style="font-weight: bold">55 Inch</span>
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True">55 Inch &nbsp&nbsp</asp:ListItem>
                <asp:ListItem>60 Inch &nbsp&nbsp</asp:ListItem>
                <asp:ListItem>65 Inch</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <ul>
                <li style="list-style: disc !important"><%#Eval("Description") %></li>
                
            </ul>
            <div style="float: right; margin-right: 160px; margin-top: 30px;">
                <asp:Button ID="ButtonBuyNow" runat="server" Text="Buy Now" />
            </div>
        </div>
    </div>
    
</asp:Content>
