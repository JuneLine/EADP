<%@ Page Title="Add Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="SREX.AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container body-container-own" style="margin-top: 5%">
        <asp:Label runat="server" ID="insertMsg"></asp:Label>
        <div class="row">
            <div class="col-md-12">
                <div class="well well-sm">
                    <div class="form-horizontal">
                        <fieldset>
                            <legend class="text-center header">ADD A NEW PRODUCT</legend>
                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-thumbs-up bigicon"></i></span>
                                <div class="col-md-8">
                                    <asp:TextBox runat="server" CssClass="form-control" ID="productNameTB" type="text" Placeholder="Name"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-dollar bigicon"></i></span>
                                <div class="col-md-8">
                                    <asp:TextBox runat="server" CssClass="form-control" ID="productPriceTB" type="text" Placeholder="Price in SGD"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-gear bigicon"></i></span>
                                <div class="col-md-8">
                                    <div class="custom-file">
                                        <asp:FileUpload runat="server" CssClass="custom-file-input" ID="FileLocation" />
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-bank bigicon"></i></span>
                                <div class="col-md-8">
                                    <asp:TextBox runat="server" CssClass="form-control" ID="inStockTB" Placeholder="Product instock"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-th-list bigicon"></i></span>
                                <div class="col-md-8">
                                    <asp:DropDownList CssClass="form-control" runat="server" ID="ddlCategory">
                                    </asp:DropDownList>
                                </div>
                            </div>

                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-file-text bigicon"></i></span>
                                <div class="col-md-8">
                                    <asp:TextBox CssClass="form-control" TextMode="multiline" Columns="50" Rows="5" runat="server" ID="ProductDescTB" Placeholder="Product Description"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12 text-center">
                                    <asp:Button ID="InsertProductBT" runat="server" CssClass="btn btn-primary btn-lg" Text="Complete" type="submit" OnClick="InsertProductButton_Click" />
                                </div>
                            </div>
                        </fieldset>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
