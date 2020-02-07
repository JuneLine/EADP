<%@ Page Title="Guide History" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuidedPurchaseHist.aspx.cs" Inherits="SREX.GuidedPurchaseHist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <style>
        .styleQR {
            position: fixed;
            top: 25%;
            left: 37.5%;
        }

        .myPanelDetails {
            width: 40%;
            height: auto;
            padding: 3%;
            border: 1px dotted black;
            border-radius: 10px;
            position: fixed;
            left: 30%;
            top: 20%;
            background-color:lightblue;
            opacity:1;
        }
    </style>
    <div class="body-container-own">
        <div class="well" style="margin-top: 20px;">
            <h3 class="text-center">Guided Tour Purchases</h3>
        </div>
        <asp:DataList runat="server" ID="DataListHist" RepeatLayout="Table" CssClass="table">
            <HeaderTemplate>
                <th class="text-center">PurchaseId</th>
                <th class="text-center">Date Purchased</th>
                <th class="text-center">Total Cost</th>
                <th class="text-center">Tour Detail</th>
                <th class="text-center">QR Code</th>
            </HeaderTemplate>
            <ItemTemplate>
                <td class="text-center"><%#Eval("PurchaseId") %></td>
                <td class="text-center"><%#Eval("Date") %></td>
                <td class="text-center">SGD<%#Eval("PaymentAmount") %></td>
                <td class="text-center">
                    <button type="button" class="btn btn-info btn-sm" id="showData" onserverclick="showData_ServerClick" runat="server" value='<%#Eval("tourId") %>'>View</button>
                </td>
                <td>
                    <p data-placement="top" class="text-center" data-toggle="tooltip" title="Proof">
                        <button value='<%#Eval("PurchaseId") %>' runat="server" onserverclick="openModalQR" class="btn btn-info btn-xs"><span class="glyphicon glyphicon-qrcode"></span></button>
                    </p>
                </td>
            </ItemTemplate>
        </asp:DataList>
        <div class="text-center">
            <asp:Button ID="BtnBackToMain" runat="server" Text="Back" class="btn btn-primary" OnClick="BtnBackToMain_Click" />
        </div>
    </div>
    <asp:Panel runat="server" CssClass="myPanelDetails" ID="GuideDetails" Visible="false">
        <button type="button" class="close" id="closeDetailPanel" runat="server" style="color:brown" onserverclick="closeDetailPanel_ServerClick">&times;</button>
        <div>                        
            <h3 class="modal-title text-center" style="font-weight: bold;">Tour Details</h3>
        </div>        
        <div class="row">
            <asp:Label runat="server" ID="lbltourname"></asp:Label>
            <br />
            <asp:Label runat="server" ID="lbltourDate"></asp:Label>
            <br />
            <asp:Label runat="server" ID="lblMeetUp"></asp:Label>
        </div>
        <div class="row">
             <asp:DataList ID="DataListInfo" runat="server" RepeatLayout="Table" CssClass="table table-bordered">
                <ItemTemplate>
                    <tr>
                        <th class="col-sm-3 text-center">Time</th>
                        <th class="col-sm-9 text-center">Activity</th>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time1") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity1") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time2") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity2") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time3") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity3") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time4") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity4") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time5") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity5") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time6") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity6") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time7") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity7") %></td>
                    </tr>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </asp:Panel>
    <div id="QRDiv" runat="server" class="styleQR" visible="false">
        <button type="button" class="close" runat="server" id="closePanel" onserverclick="closePanel_ServerClick">&times;</button>
        <asp:Panel runat="server" ID="QRPanel" Width="410" Height="410"></asp:Panel>
    </div>
</asp:Content>

