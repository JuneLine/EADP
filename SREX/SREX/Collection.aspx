<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Collection.aspx.cs" Inherits="SREX.Collection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Product.css" rel="stylesheet" />
    <div class="jumbotron" style="overflow: auto">
        <div class="row">
            <div class="col-lg-4 col-md-12 col-sm-12">
                <img src="profile.png" style="height: 50%; width: 50%; margin-left: 25%" />
            </div>
            <div class="col-lg-8 col-md-12 col-sm-12">
                <table class="MyTableThing table" style="margin-top: .5%">
                    <tr>
                        <td style="font-weight: bold;">Name:
                        </td>
                        <td style="font-size: 20px;">
                            <asp:Label ID="LabelName" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">Passport:
                        </td>
                        <td style="font-size: 20px;">
                            <asp:Label ID="LabelPassport" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">Date Of Birth:
                        </td>
                        <td style="font-size: 20px;">
                            <asp:Label ID="LabelDOB" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="container" style="margin-top: 1%; margin-bottom: 15%;">
        <span style="font-size: 16px;">Order: 
            <span style="color: cadetblue">
                <asp:Label ID="LabelOrderNum" runat="server" Text=""></asp:Label>
            </span>
        </span>
        <div class="row">
            <asp:DataList ID="DataListPurchaseHistory" runat="server" RepeatLayout="Table" CssClass="table table-striped body-container-own">
                <HeaderTemplate>
                    <th class="text-center" style="height: 38px">Item:</th>
                    <th class="text-center" style="height: 38px">Name:</th>
                    <th class="text-center" style="height: 38px">Quantity</th>
                    <th class="text-center" style="height: 38px">Price:</th>
                </HeaderTemplate>
                <ItemTemplate>
                    <td class="text-center">
                        <img src='<%# String.Format("Pictures/{0}", Eval("Prod.PictureName")) %>' style="max-height: 200px; max-width: 400px;" />
                    </td>
                    <td class="text-center"><%#Eval("Prod.Name") %></td>
                    <td class="text-center"><%#Eval("Quantity") %></td>
                    <td class="text-center"><%#Eval("Prod.Price") %></td>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>
