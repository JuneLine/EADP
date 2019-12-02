<%@ Page Title="Product List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="SREX.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">

        <div class="row content">
            <div class="col-sm-2 sidenav hidden-xs">
                <h3>Categories</h3>
                <ul class="nav nav-pills nav-stacked">
                    <li><a href="ProductList?category=cloth">Clothing</a></li>
                    <li><a href="ProductList?category=shoes">Shoes</a></li>
                    <li><a href="ProductList?category=accessories">Accessories</a></li>
                    <li><a href="ProductList?category=bag">Bag</a></li>
                    <li><a href="ProductList?category=electronic-devices">Electronic Devices</a></li>
                    <li><a href="ProductList?category=watch">Watch</a></li>
                    <li><a href="ProductList?category=sportGroup">Sports</a></li>
                    <li><a href="ProductList?category=cosmetics-perfume">Cosmetics & Perfume</a></li>
                    <li><a href="ProductList?category=native-product">Native Product</a></li>
                </ul>
                <br>
            </div>
            <br>

            <div class="col-sm-10">
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

                <div class="row body-container-own">
                    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
                        <ItemTemplate>
                            <a href="ProductInfo?productId=<%#Eval("Id") %>">
                                <div class="col-sm-12">
                                    <div class="panel panel-primary">
                                        <div class="panel-heading"><%#Eval("Name") %></div>
                                        <div class="panel-body">
                                            <asp:Image runat="server" class="img-responsive" ImageUrl='<%#Eval("PictureName") %>' Style="width: 100%;"></asp:Image>
                                        </div>
                                        <div class="panel-footer">S$<%#Eval("Price") %></div>
                                    </div>
                                </div>
                            </a>
                        </ItemTemplate>
                    </asp:DataList>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
