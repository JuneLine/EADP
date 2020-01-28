<%@ Page Title="QR Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuidedQRpage.aspx.cs" Inherits="SREX.GuidedQRpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <link href="Content/Guide.css" rel="stylesheet" />
    <div class="jumbotron">
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12">
                <a href="GuidedPurchaseHist.aspx" class="buttonRight">Back to History</a>
            </div>
            <div class="col-lg-4 col-md-12 col-sm-12">
                <img src="https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png" style="height: 60%; width: 60%; margin-left: 25%; margin-top: 10%;" />
            </div>
            <div class="col-lg-8 col-md-12 col-sm-12">
                <table class="table" style="margin-top: 10%; font-size: 1.5em;">
                    <tr>
                        <td style="font-weight: bold;">Name:
                        </td>
                        <td>&nbsp<asp:Label runat="server" ID="lblUserName"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">Contact:
                        </td>
                        <td>&nbsp<asp:Label runat="server" ID="lblContact"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">Payment Made:
                        </td>
                        <td>&nbspSGD <asp:Label runat="server" ID="lblPayment"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">Date Of Purchase Made:
                        </td>
                        <td>&nbsp<asp:Label runat="server" ID="lblDatePurch"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="container body-container-own">
        <div class="row" style="margin-bottom: 2.5%; font-size:1.2em;">
            <div class="col-sm-3">
                <asp:DataList runat="server" ID="DataListInfo1">
                    <ItemTemplate>
                        <label>Name Of Tour:</label>
                        <p><%#Eval("tourName") %></p>
                        <label>Date Of Tour:</label>
                        <p><%#Eval("Date") %></p>
                        <label>Meet Up:</label>
                        <p><%#Eval("meetUpTime") %> @ <%#Eval("meetUpLocation") %></p>
                        <asp:Label runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:DataList>
                <label>Tickets bought:</label>
                <p><asp:Label runat="server" ID="lblAQuant"></asp:Label> Adult Tickets<br />
                    <asp:Label runat="server" ID="lblCQuant"></asp:Label> Child Tickets<br />
                    <asp:Label runat="server" ID="lblSQuant"></asp:Label> Senior Tickets
                </p>
            </div>
            <div class="col-sm-9">
                <asp:DataList ID="DataListInfo2" runat="server" RepeatLayout="Table" CssClass="table table-bordered">
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
        </div>
        <%--<div class="row">
            <div class="col-sm-12">
                <table class="table table-hover table-bordered col-sm-12 text-center" style="font-size: 16px;">
                    <tr>
                        <th class="col-sm-3">Time</th>
                        <th class="col-sm-9">Activity</th>
                    </tr>
                    <tr>
                        <td>1000-1100</td>
                        <td>Meet At Khatib MRT Station<br />
                            Traveling time
                        </td>
                    </tr>
                    <tr>
                        <td>1100-1200</td>
                        <td rowspan="2">Wild Discoverer Tour
                        </td>
                    </tr>
                    <tr>
                        <td>1200-1300</td>
                    </tr>
                    <tr>
                        <td>1300-1400</td>
                        <td>Lunch Time</td>
                    </tr>
                    <tr>
                        <td>1400-1500</td>
                        <td rowspan="2">Free Roam</td>
                    </tr>
                    <tr>
                        <td>1500-1600</td>
                    </tr>
                    <tr>
                        <td>1600-1700</td>
                        <td>Gentle Giants Wildlife Tour</td>
                    </tr>
                    <tr>
                        <td style="height: 38px">1700</td>
                        <td style="height: 38px">End Of Tour</td>
                    </tr>
                </table>
            </div>
        </div>--%>
    </div>
    <br />
    <br />
</asp:Content>
