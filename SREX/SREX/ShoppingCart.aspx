<%@ Page Title="Shopping Cart" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="SREX.ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin-top: 5%">
        <div class="row">
            <div class="col-xs-12">
                <div class="panel panel-info">
                    <div class="panel-heading">
                        <div class="panel-title">
                            <div class="row">
                                <div class="col-xs-6">
                                    <h5><span class="glyphicon glyphicon-shopping-cart"></span>Shopping Cart</h5>
                                </div>
                                <div class="col-xs-2" style="float: right">
                                    <button type="button" class="btn btn-primary btn-sm btn-block">
                                        <span class="glyphicon glyphicon-share-alt"></span>Continue shopping
							
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-xs-2">
                                <img class="img-responsive" src="http://placehold.it/100x70">
                            </div>
                            <div class="col-xs-4">
                                <h4 class="product-name"><strong>Product name</strong></h4>
                                <h4><small>Product description</small></h4>
                            </div>
                            <div class="col-xs-6">
                                <div class="col-xs-6 text-right">
                                    <h6><strong>25.00 <span class="text-muted">x</span></strong></h6>
                                </div>
                                <div class="col-xs-2">
                                    <input type="number" class="form-control text-center" value="1">
                                </div>
                                <div class="col-xs-2">
                                    <button class="btn btn-danger btn-sm"><i class="fa fa-trash-o"></i></button>
                                </div>
                            </div>
                        </div>
                        <hr>
                        <div class="row">
                            <div class="col-xs-2">
                                <img class="img-responsive" src="http://placehold.it/100x70">
                            </div>
                            <div class="col-xs-4">
                                <h4 class="product-name"><strong>Product name</strong></h4>
                                <h4><small>Product description</small></h4>
                            </div>
                            <div class="col-xs-6">
                                <div class="col-xs-6 text-right">
                                    <h6><strong>25.00 <span class="text-muted">x</span></strong></h6>
                                </div>
                                <div class="col-xs-2">
                                    <input type="number" class="form-control text-center" value="1">
                                </div>
                                <div class="col-xs-2">
                                    <button class="btn btn-danger btn-sm"><i class="fa fa-trash-o"></i></button>
                                </div>
                            </div>
                        </div>
                        <hr>
                    </div>
                    <div class="panel-footer">
                        <div class="row text-center">
                            <div class="col-xs-9">
                                <h4 class="text-right">Total <strong>$50.00</strong></h4>
                            </div>
                            <div class="col-xs-3">
                                <button type="button" class="btn btn-success btn-block">
                                    Checkout
						
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
