<%@ Page Title="Edit Product Infomation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProductInfo.aspx.cs" Inherits="SREX.EditProductInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container body-container-own" style="margin-top: 5%">
        <asp:Label runat="server" ID="UpdateMsg"></asp:Label>
        <div class="row">
            <div class="col-md-12">
                <div class="well well-sm">
                    <div class="form-horizontal">
                        <fieldset>
                            <legend class="text-center header">UPDATE CURRENT PRODUCT</legend>
                            <div class="row">
                                <div class="col-md-8">
                                    <div class="form-group">
                                        <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-thumbs-up bigicon"></i></span>
                                        <div class="col-md-9">
                                            <asp:TextBox runat="server" CssClass="form-control" ID="productNameTB" type="text" Placeholder="Name"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-dollar bigicon"></i></span>
                                        <div class="col-md-9">
                                            <asp:TextBox runat="server" CssClass="form-control" ID="productPriceTB" type="text" Placeholder="Price in SGD"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-gear bigicon"></i></span>
                                        <div class="col-md-8">
                                            <div class="col-md-10">
                                                <div class="custom-file">
                                                    <asp:FileUpload runat="server" CssClass="custom-file-input" ID="FileLocation" />
                                                </div>
                                            </div>
                                            <div class="col-md-2">
                                                <asp:Button runat="server" ID="UploadImage" CssClass="btn btn-primary" Text="Upload Image" OnClick="UploadImage_Click"/>
                                            </div>

                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-bank bigicon"></i></span>
                                        <div class="col-md-9">
                                            <asp:TextBox runat="server" CssClass="form-control" ID="inStockTB" Placeholder="Product instock"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-th-list bigicon"></i></span>
                                        <div class="col-md-9">
                                            <asp:DropDownList CssClass="form-control" runat="server" ID="ddlCategory">
                                                <asp:ListItem Text="cloth" Selected="true" />
                                                <asp:ListItem Text="shoes" />
                                                <asp:ListItem Text="accessories" />
                                                <asp:ListItem Text="bag" />
                                                <asp:ListItem Text="watch" />
                                                <asp:ListItem Text="sportGroup" />
                                                <asp:ListItem Text="native-product" />
                                                <asp:ListItem Text="electronic-device" />
                                                <asp:ListItem Text="cosmetics-perfume" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-file-text bigicon"></i></span>
                                        <div class="col-md-9">
                                            <asp:TextBox CssClass="form-control" TextMode="multiline" Columns="50" Rows="5" runat="server" ID="ProductDescTB" Placeholder="Product Description"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-12 text-center">
                                            <asp:Button ID="UpdateProductBT" runat="server" CssClass="btn btn-primary btn-lg" Text="Complete" type="submit" OnClick="UpdateProductButton_Click" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <asp:Image runat="server" class="img-responsive" ID="imageShow" Style="width: 260px; margin-left: auto; margin-right: auto;"></asp:Image>
                                </div>
                            </div>

                        </fieldset>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
