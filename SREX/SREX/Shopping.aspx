<%@ Page Title="Shopping Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shopping.aspx.cs" Inherits="SREX.Shopping" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-2 mx-auto text-center">
            <img src="default.png" id="ShoppingLogo" />
        </div>
        <div class="col-sm-8">
            <div class="input-group">
                <input type="text" class="form-control" placeholder="Search for...">
                <span class="input-group-btn">
                    <button class="btn btn-default" type="button">Go!</button>
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
            <div class="col-12">
                <div class="section-heading text-center">
                    <h2>Categories</h2>
                </div>
            </div>
        </div>
    </div>
    <div class="top_catagory_area section-padding-0-40 clearfix">
        <div class="container">
            <div class="row justify-content-center">
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Cloth.jpg);">
                        <div class="catagory-content">
                            <a href="#">Clothing</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Shoes.jpg);">
                        <div class="catagory-content">
                            <a href="#">Shoes</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Accessories.jpg);">
                        <div class="catagory-content">
                            <a href="#">Accessories</a>
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
                            <a href="#">Bag</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Electronic.jpg);">
                        <div class="catagory-content">
                            <a href="#">Electronic devices</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Watch.jpg);">
                        <div class="catagory-content">
                            <a href="#">Watch</a>
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
                            <a href="SportsGroup">Sports</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/Makeup.jpg);">
                        <div class="catagory-content">
                            <a href="#">Cosmetics & Perfume</a>
                        </div>
                    </div>
                </div>
                <!-- Single Catagory -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(Pictures/LocalFood.jpg);">
                        <div class="catagory-content">
                            <a href="#">Native Product</a>
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
                    <h2>Recommended Products</h2>
                </div>
            </div>
        </div>
    </div>
    <div class="container body-container-own">
        <div class="row">
            <div class="col-sm-4">
                <div class="panel panel-primary">
                    <div class="panel-heading">BLACK FRIDAY DEAL</div>
                    <div class="panel-body">
                        <img src="Pictures/Watch.jpg" class="img-responsive" style="width: 100%" alt="Image">
                    </div>
                    <div class="panel-footer">30% Discount for last few days!</div>
                </div>
            </div>
            <div class="col-sm-4">
                <div class="panel panel-primary">
                    <div class="panel-heading">BLACK FRIDAY DEAL</div>
                    <div class="panel-body">
                        <img src="Pictures/Cloth.jpg" class="img-responsive" style="width: 100%" alt="Image">
                    </div>
                    <div class="panel-footer">10% Discount</div>
                </div>
            </div>
            <div class="col-sm-4">
                <div class="panel panel-primary">
                    <div class="panel-heading">BLACK FRIDAY DEAL</div>
                    <div class="panel-body">
                        <img src="Pictures/Bag.jpg" class="img-responsive" style="width: 100%" alt="Image">
                    </div>
                    <div class="panel-footer">Buy one, Get one Free</div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
