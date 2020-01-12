<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Collection.aspx.cs" Inherits="SREX.Collection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Product.css" rel="stylesheet" />
    <div class="jumbotron" style="overflow: auto">
        <div class="row">
            <div class="col-lg-4 col-md-12 col-sm-12">
                <img src="https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png" style="height: 50%; width: 50%; margin-left: 25%" />
            </div>
            <div class="col-lg-8 col-md-12 col-sm-12">
                <table class="MyTableThing table" style="margin-top: .5%">
                    <tr>
                        <td style="font-weight: bold;"> Name:
                        </td>
                        <td style="font-size: 20px;">Jonathan Smith
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">NRIC:
                        </td>
                        <td style="font-size: 20px;">S1234567S
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">Date Of Birth:
                        </td>
                        <td style="font-size: 20px;">05/06/2007
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="container" style="margin-top: 1%; margin-bottom: 15%;">
        <span style="font-size: 16px;">Order: <span style="color: cadetblue">#28943898</span></span>
        <div class="row">
            <table class="table table-striped table-hover" style="margin-top: 2%;">
                <thead>
                    <tr>
                        <th>Item:
                        </th>
                        <th>Name:
                        </th>
                        <th>Quantity:
                        </th>
                        <th>Price:
                        </th>
                    </tr>
                </thead>
                <tr>
                    <td>
                        <img src="https://images-na.ssl-images-amazon.com/images/I/91mqp0z-TiL._SX679_.jpg" style="max-height: 200px; max-width: 400px;"/>
                    </td>
                    <td>TCL 55" Something OLED Special TV
                    </td>
                    <td>1
                    </td>
                    <td>S$359.99
                    </td>
                </tr>
                <tr>
                    <td>
                        <img src="https://images-na.ssl-images-amazon.com/images/I/61Z5%2B%2BUWAbL._AC_UY695_.jpg" style="max-height: 200px; max-width: 400px;"/>
                    </td>
                    <td>Very Expensive Addidas/Nike Shoe Which You Can't Afford Test Test
                    </td>
                    <td>1
                    </td>
                    <td>S$359.99
                    </td>
                </tr>
                <tr>
                    <td>
                        <img src="Pictures/model-2.jpg" style="max-height: 200px; max-width: 400px;"/>
                    </td>
                    <td>Some Random Dress I Found On Amazon That Is Not $300 Actually
                    </td>
                    <td>1
                    </td>
                    <td>S$359.99
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
