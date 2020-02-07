<%@ Page Title="Shopping Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shopping.aspx.cs" Inherits="SREX.Shopping" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-2 mx-auto text-center">
            <img src="default.png" id="ShoppingLogo" />
        </div>
        <div class="col-sm-8">
            <div class="input-group">
                <asp:TextBox CssClass="form-control" runat="server" ID="targetItem" Placeholder="Search for..."></asp:TextBox>
                <span class="input-group-btn">
                    <asp:Button ID="SearchButton" runat="server" CssClass="btn btn-default" Text="Go" OnClick="SearchButton_Click" />
                </span>
            </div>
        </div>
    </div>
    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
            <li data-target="#carousel-example-generic" data-slide-to="1"></li>
            <li data-target="#carousel-example-generic" data-slide-to="2"></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img src="https://mdbootstrap.com/img/Photos/Slides/img%20(8).jpg" alt="Products">
                <div class="carousel-caption">
                    <h3>Buy one get one free.</h3>
                    <p>Promotion 20% discount!</p>
                </div>
            </div>
            <div class="item">
                <img src="https://mdbootstrap.com/img/Photos/Slides/img%20(136).jpg" alt="Cloth">
                <div class="carousel-caption">
                    <h3>Discount for last two days!</h3>
                    <p>Promotion 20% discount!</p>
                </div>
            </div>
            <div class="item">
                <img src="https://mdbootstrap.com/img/Photos/Slides/img%20(132).jpg" alt="Camera">
                <div class="carousel-caption">
                    <h3>Attention!</h3>
                    <p>Promotion 50% discount!</p>
                </div>
            </div>
        </div>

        <!-- Controls -->
        <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <!-- Catagory -->
    <div class="container section-padding-40-0">
        <div class="row">
            <div id="catDesign" runat="server" class="col-sm-12">
                <div id="catTitle" runat="server" class="section-heading text-right">
                    <h2 id="cat" runat="server">Categories</h2>
                </div>
            </div>
            <div id="forAdmin2" runat="server" class="col-sm-4">
                <div id="addProduct" runat="server" class="section-heading">
                    <asp:Button ID="ButtonAddProd" runat="server" CssClass="btn btn-primary" Text="Add Product" OnClick="btAddProduct_Click" />
                </div>
            </div>
        </div>
    </div>
    <div class="top_catagory_area section-padding-0-40 clearfix">
        <div class="container">
            <div class="row justify-content-center">
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Sweater.jpg);">
                        <div class="catagory-content">
                            <a href="ProductList?category=cloth&sortby=Sold&order=Asc">Clothing</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Shoes.jpg);">
                        <div class="catagory-content">
                            <a href="ProductList?category=shoes&sortby=Sold&order=Asc">Shoes</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Accessories.jpg);">
                        <div class="catagory-content">
                            <a href="ProductList?category=accessories&sortby=Sold&order=Asc">Accessories</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="top_catagory_area clearfix">
        <div class="container">
            <div class="row justify-content-center">
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Bag.jpg);">
                        <div class="catagory-content">
                            <a href="ProductList?category=bag&sortby=Sold&order=Asc">Bag</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Electronic.jpg);">
                        <div class="catagory-content">
                            <a href="ProductList?category=electronic-device&sortby=Sold&order=Asc">Electronic devices</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Watch.jpg);">
                        <div class="catagory-content">
                            <a href="ProductList?category=watch&sortby=Sold&order=Asc">Watch</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="top_catagory_area section-padding-40 clearfix">
        <div class="container">
            <div class="row justify-content-center">
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Sports.jpg);">
                        <div class="catagory-content">
                            <a href="ProductList?category=sportGroup&sortby=Sold&order=Asc">Sports</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Makeup.jpg);">
                        <div class="catagory-content">
                            <a href="ProductList?category=cosmetics-perfume&sortby=Sold&order=Asc">Cosmetics & Perfume</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/LocalFood.jpg);">
                        <div class="catagory-content">
                            <a href="ProductList?category=native-product&sortby=Sold&order=Asc">Native Product</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-12">
                <div class="section-heading text-center">
                    <h2>Popular Products</h2>
                </div>
            </div>
        </div>
    </div>
    <div class="container body-container-own">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatLayout="Table">
            <ItemTemplate>
                <div style="width: 100%; padding-right: 2%; padding-left: 2%;">
                    <a href="ProductInfo?productId=<%#Eval("Id") %>">

                        <div class="panel panel-primary">
                            <div class="panel-heading"><%#Eval("Name") %></div>
                            <div class="panel-body">
                                <asp:Image runat="server" class="img-responsive" ImageUrl='<%# String.Format("Pictures/{0}", Eval("PictureName") ) %>' Style="width: 100%;"></asp:Image>
                            </div>
                            <div class="panel-footer">S$<%#Eval("Price") %></div>
                        </div>

                    </a>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
    
</asp:Content>
