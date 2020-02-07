<%@ Page Title="Shopping History" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingHistory.aspx.cs" Inherits="SREX.ShoppingHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .styleQR {
            position: fixed;
            top: 25%;
            left: 37.5%;
        }
    </style>

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
                    <button value='<%#Eval("OrderID") %>' runat="server" onserverclick="GoToPage_ServerClick" class="btn btn-primary btn-xs"><span class="glyphicon glyphicon-eye-open"></span></button>
                </p>
            </td>
            <td>
                <p data-placement="top" class="text-center" data-toggle="tooltip" title="Proof">
                    <button value='<%#Eval("OrderID") %>' runat="server" onserverclick="openModalQR" class="btn btn-info btn-xs"><span class="glyphicon glyphicon-qrcode"></span></button>
                </p>
            </td>
        </ItemTemplate>
    </asp:DataList>
    <asp:Panel ID="Panel1" runat="server" CssClass="modalPanel">
        <div class="modal-content">
            <button class="close" onclick='document.getElementById("MainContent_Panel1").style.display = "none"; return false;'><span>&times</span></button>
            <p>
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
            </p>
        </div>
    </asp:Panel>
    <div id="QRDiv" runat="server" class="styleQR" visible="false">       
        <asp:Panel ID="QR" runat="server" Width="410" Height="410"></asp:Panel>
    </div>
</asp:Content>
