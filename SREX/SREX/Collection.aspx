<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Collection.aspx.cs" Inherits="SREX.Collection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Product.css" rel="stylesheet" />
    <div class="jumbotron" style="overflow: auto">
        <div class="row">
            <div class="col-lg-4 col-md-12 col-sm-12">
                <img src="https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png" style="height: 50%; width: 50%; margin-left: 25%" />
            </div>
            <div class="col-lg-8 col-md-12 col-sm-12">
                <table style="margin-top: 8%">
                    <tr>
                        <td>Name:
                        </td>
                        <td>Jonathan Smith
                        </td>
                    </tr>
                    <tr>
                        <td>NRIC:
                        </td>
                        <td>S1234567S
                        </td>
                    </tr>
                    <tr>
                        <td>Date Of Birth:
                        </td>
                        <td>05/06/2007
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="container">
        <span style="font-size: 16px;">Order: <span style="color: cadetblue">#28943898</span></span>
        <div class="row" style="margin-left: 5%;margin-top: 5%;">
            <table class="OrderStuff">
                <tr>
                    <th style="padding-right:50%;">Item:
                    </th>
                    <th style="padding-right:25%">Name:
                    </th>
                    <th>Quantity:
                    </th>
                    <th>Price:
                    </th>
                </tr>
                <tr>
                    <td>
                        <img src="https://images-na.ssl-images-amazon.com/images/I/91mqp0z-TiL._SX679_.jpg" style="max-height: 200px; max-width: 300px; height: 100%; width: 100%" />
                    </td>
                    <td>TCL 55" TV
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
