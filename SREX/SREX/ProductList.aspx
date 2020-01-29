<%@ Page Title="Product List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="SREX.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="row content">
            <div class="col-sm-2 sidenav hidden-xs" style="margin-top: 10%;">
                <h3>Categories</h3>
                <ul class="nav nav-pills nav-stacked">
                    <li><a href="ProductList?category=cloth&sortby=Sold&order=Asc">Clothing</a></li>
                    <li><a href="ProductList?category=shoes&sortby=Sold&order=Asc">Shoes</a></li>
                    <li><a href="ProductList?category=accessories&sortby=Sold&order=Asc">Accessories</a></li>
                    <li><a href="ProductList?category=bag&sortby=Sold&order=Asc">Bag</a></li>
                    <li><a href="ProductList?category=electronic-devices&sortby=Sold&order=Asc">Electronic Devices</a></li>
                    <li><a href="ProductList?category=watch&sortby=Sold&order=Asc">Watch</a></li>
                    <li><a href="ProductList?category=sportGroup&sortby=Sold&order=Asc">Sports</a></li>
                    <li><a href="ProductList?category=cosmetics-perfume&sortby=Sold&order=Asc">Cosmetics & Perfume</a></li>
                    <li><a href="ProductList?category=native-product&sortby=Sold&order=Asc">Native Product</a></li>
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
                            <asp:TextBox CssClass="form-control" runat="server" ID="targetItem" Placeholder="Search for..."></asp:TextBox>
                            <span class="input-group-btn">
                                <asp:Button ID="SearchButton" runat="server" CssClass="btn btn-default" Text="Go" OnClick="SearchButton_Click" />
                            </span>
                        </div>
                    </div>
                    <div class="col-sm-2 mx-auto text-center" style="margin-top: 2.5%;">
                        <div class="dropdown">
                            <button class="btn btn-primary dropdown-toggle" type="button" style="width: 180px;" data-toggle="dropdown">
                                <asp:Label runat="server" ID="sortBySth">Sort</asp:Label>
                            <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu">
                                <li><a href="#" runat="server" id="SortByNameAsc">Sort by Name (A-Z)</a></li>
                                <li><a href="#" runat="server" id="SortByNameDesc">Sort by Name (Z-A)</a></li>
                                <li><a href="#" runat="server" id="SortByPriceAsc">Sort by Price (low-high)</a></li>
                                <li><a href="#" runat="server" id="SortByPriceDesc">Sort by Price (high-low)</a></li>
                                <li><a href="#" runat="server" id="SortByPopularityAsc">Sort by Popularity</a></li>
                            </ul>
                        </div>
                    </div>
                </div>

                <div class="row body-container-own">
                    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                        <ItemTemplate>
                            <a href="ProductInfo?productId=<%#Eval("Id") %>">
                                <div style="width: 100%; padding-right: 2%; padding-left: 2%;">
                                    <div class="panel panel-primary">
                                        <div class="panel-heading"><%#Eval("Name") %></div>
                                        <div class="panel-body">
                                            <asp:Image runat="server" class="img-responsive" ImageUrl='<%# String.Format("Pictures/{0}", Eval("PictureName") ) %>' Style="width: 100%;"></asp:Image>
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
