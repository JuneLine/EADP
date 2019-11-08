<%@ Page Title="Shopping Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shopping.aspx.cs" Inherits="SREX.Shopping" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-4 mx-auto text-center">
            <img src="default.png"  id="ShoppingLogo"/>
        </div>
        <div class="col-sm-8">

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
</asp:Content>
