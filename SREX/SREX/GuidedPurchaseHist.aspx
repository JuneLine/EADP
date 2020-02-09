<%@ Page Title="Guide History" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuidedPurchaseHist.aspx.cs" Inherits="SREX.GuidedPurchaseHist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <div class="body-container-own">
        <div class="well" style="margin-top: 20px;">
            <h3 class="text-center">Guided Tour Purchases</h3>
        </div>
        <div class="panel panel-info">
            <div class="panel-heading">
                <div class="panel-title">
                    <div class="row">
                        <div class="col-xs-6">
                            <h5><span class="glyphicon"></span>Tour Bought</h5>
                        </div>
                        <div class="col-xs-2" style="float: right">
                            <div class="text-center">
                                <asp:Button ID="BtnBackToMain" runat="server" Text="Back To Tour" class="btn btn-primary btn-sm btn-block" OnClick="BtnBackToMain_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <asp:DataList runat="server" ID="DataListHist" RepeatLayout="Table" CssClass="table">
                <HeaderTemplate>
                    <th class="text-center">Date Purchased</th>
                    <th class="text-center">Tickets Bought</th>
                    <th class="text-center">Total Cost</th>
                    <th class="text-center">Tour Detail</th>
                </HeaderTemplate>
                <ItemTemplate>
                    <td class="text-center"><%#Eval("Date") %></td>
                    <td class="text-center"><%#Eval("AdultQuantity") %> Adults, <%#Eval("ChildQuantity") %> Child, <%#Eval("SeniorQuantity") %> Seniors</td>
                    <td class="text-center">SGD<%#Eval("PaymentAmount") %></td>
                    <td class="text-center">
                        <button type="button" class="btn btn-info btn-sm" id="showData" onserverclick="showData_ServerClick" runat="server" value='<%#Eval("tourId") %>'>View</button>
                    </td>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
    <asp:Panel runat="server" CssClass="myPanelDetails" ID="GuideDetails" Visible="false">
        <button type="button" class="close" id="closeDetailPanel" runat="server" style="color: brown" onserverclick="closeDetailPanel_ServerClick">&times;</button>
        <div class="modal-title">
            <h3 class="text-center" style="font-weight: bold;">Tour Details</h3>
        </div>
        <div class="modal-content">
            <asp:Label runat="server" ID="lbltourname"></asp:Label>
            <br />
            <asp:Label runat="server" ID="lbltourDate"></asp:Label>
            <br />
            <asp:Label runat="server" ID="lblMeetUp"></asp:Label>

            <asp:DataList ID="DataListInfo" runat="server" RepeatLayout="Table" CssClass="table table-bordered">
                <ItemTemplate>
                    <asp:Table runat="server" CssClass="table table-bordered">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell runat="server" class="col-sm-3 text-center">Time</asp:TableHeaderCell>
                            <asp:TableHeaderCell runat="server" class="col-sm-9 text-center">Activity</asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                        <asp:TableRow>
                            <asp:TableCell runat="server" class="col-sm-3 text-center"><%# Eval("Time1") %></asp:TableCell>
                            <asp:TableCell runat="server" class="col-sm-9 text-center"><%# Eval("Activity1") %></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell runat="server" class="col-sm-3 text-center"><%# Eval("Time2") %></asp:TableCell>
                            <asp:TableCell runat="server" class="col-sm-9 text-center"><%# Eval("Activity2") %></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell runat="server" class="col-sm-3 text-center"><%# Eval("Time3") %></asp:TableCell>
                            <asp:TableCell runat="server" class="col-sm-9 text-center"><%# Eval("Activity3") %></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell runat="server" class="col-sm-3 text-center"><%# Eval("Time4") %></asp:TableCell>
                            <asp:TableCell runat="server" class="col-sm-9 text-center"><%# Eval("Activity4") %></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell runat="server" class="col-sm-3 text-center"><%# Eval("Time5") %></asp:TableCell>
                            <asp:TableCell runat="server" class="col-sm-9 text-center"><%# Eval("Activity5") %></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell runat="server" class="col-sm-3 text-center"><%# Eval("Time6") %></asp:TableCell>
                            <asp:TableCell runat="server" class="col-sm-9 text-center"><%# Eval("Activity6") %></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell runat="server" class="col-sm-3 text-center"><%# Eval("Time7") %></asp:TableCell>
                            <asp:TableCell runat="server" class="col-sm-9 text-center"><%# Eval("Activity7") %></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </asp:Panel>
</asp:Content>

