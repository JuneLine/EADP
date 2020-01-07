<%@ Page Title="Shopping History" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingHistory.aspx.cs" Inherits="SREX.ShoppingHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="well" style="margin-top: 20px;">
        <h3 class="text-center">Purchase History Review</h3>
    </div>
    <asp:DataList ID="DataListPurchase" runat="server" RepeatLayout="Table" CssClass="table table-striped body-container-own">
        <HeaderTemplate>
            <th class="text-center" style="height: 38px">Order Id</th>
            <th class="text-center" style="height: 38px">Purchase Date</th>
            <th class="text-center" style="height: 38px">Total Cost</th>
            <th class="text-center" style="height: 38px">Order Detail</th>
            <th class="text-center" style="height: 38px">QR Code</th>
        </HeaderTemplate>
        <ItemTemplate>
            <td class="text-center"><%#Eval("OrderID") %></td>
            <td class="text-center"><%#Eval("DateOfPurchase") %></td>
            <td class="text-center"><%#Eval("Price") %></td>
            <td class="text-center">
                <p data-placement="top" class="text-center" data-toggle="tooltip" title="View">
                    <button value=<%#Eval("OrderID") %> runat="server" onserverclick="Unnamed_ServerClick" class="btn btn-primary btn-xs"><span class="glyphicon glyphicon-eye-open"></span></button>
                </p>
            </td>
            <td>
                <p data-placement="top" class="text-center" data-toggle="tooltip" title="Proof">
                    <button class="btn btn-info btn-xs"><span class="glyphicon glyphicon-qrcode"></span></button>
                </p>
            </td>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
