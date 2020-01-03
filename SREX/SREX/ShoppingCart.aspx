<%@ Page Title="Shopping Cart" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="SREX.ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="https://www.paypal.com/sdk/js?client-id=AYsfqEHpi7QDbWDoXyglblNpv-sAfE5v7Hb9QOhEirQHzJpD31ecvAxmGGy8QJtXUZoWxEdxZdlAC9no&disable-funding=card&currency=SGD&locale=en_SG"></script>
    <script>
        paypal.Buttons({
            createOrder: function (data, actions) {
                return actions.order.create({
                    purchase_units: [{
                        amount: {
                            value: <%=FeesPayable%>
                        }
                    }]
                });
            },
            onApprove: function (data, actions) {
                return actions.order.capture().then(function (details) {
                    alert('Transaction completed by ' + details.payer.name.given_name);
                    PageMethods.set_path('ShoppingCart.aspx');
                    PageMethods.Result(data.orderID, details.purchase_units[0].amount.value);
                });

            }
        }).render('#paypalCheckout');
    </script>
    <div class="container body-container-own" style="margin-top: 5%">
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
                                    <a href="Shopping">
                                        <button class="btn btn-primary btn-sm btn-block">
                                            <span class="glyphicon glyphicon-share-alt"></span>Continue shopping
                                        </button>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="panel-body">
                        <div id="alertMessage" runat="server" role="alert">
                            <asp:Label runat="server" ID="CartMessage"></asp:Label>
                        </div>
                        <div class="row">
                            <asp:DataList ID="DataList1" runat="server" RepeatLayout="Table" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
                                <ItemTemplate>
                                    <div class="col-xs-3">
                                        <asp:Image runat="server" class="img-responsive" ID="productImage" ImageUrl='<%# String.Format("Pictures/{0}", Eval("Prod.PictureName") ) %>' Style="width: 260px; margin-left: auto; margin-bottom: 15%; margin-right: auto;"></asp:Image>
                                        <hr />
                                    </div>
                                    <div class="col-xs-6">
                                        <h4><small><%#Eval("Prod.Name") %></small></h4>
                                    </div>
                                    <div class="col-xs-3">
                                        <div class="col-xs-5 text-right">
                                            Price/Item
                                            <h6><strong>S$  <%#Eval("Prod.Price") %></strong></h6>
                                        </div>
                                        <div class="col-xs-4">
                                            Quantity:
                                            <asp:Label runat="server" class="form-control text-center"><%#Eval("Quantity") %></asp:Label>
                                        </div>
                                        <div class="col-xs-3">
                                            <br />
                                            <asp:LinkButton ID="DeleteCartItem" CommandArgument='<%#Eval("Prod.Id") %>' OnClick="prodDelBtn_Click" runat="server" CssClass="btn btn-danger btn-sm">Delete</asp:LinkButton>
                                        </div>
                                    </div>

                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                        <hr>
                        <div style="float: right; font-size: x-large; margin-right: 5%">
                            Total:S$
                            <asp:Label ID="LbTotal" runat="server" Style="float: right"></asp:Label>
                        </div>
                    </div>
                    <div class="panel-footer">
                        <div class="row text-center">
                            <div class="col-xs-9">
                            </div>
                            <div class="col-xs-3" id="paypalCheckout">
                                <%--<asp:Button CssClass="btn btn-success btn-block" Text="Checkout" runat="server" ID="CheckOutBt" OnClick="CheckOutBt_Click" />--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
