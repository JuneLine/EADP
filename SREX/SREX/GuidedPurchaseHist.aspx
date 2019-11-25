<%@ Page Title="Guide History" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuidedPurchaseHist.aspx.cs" Inherits="SREX.GuidedPurchaseHist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <div class="well" style="margin-top: 20px;">
        <h3 class="text-center">Guided Tour Purchases</h3>
    </div>
    <table id="mytable" class="table table-bordred table-hover table-striped body-container-own">
        <tr>
            <th class="text-center">Purchase Id</th>
            <th class="text-center">Name Of Tour</th>
            <th class="text-center">Total Cost</th>
            <th class="text-center">Tour Detail</th>
            <th class="text-center">QR Code</th>
        </tr>
        <tr>
            <td class="text-center">1</td>
            <td class="text-center">Day Tour At Singapore ZOO</td>
            <td class="text-center">$150(2 Adult, 1 Child)</td>
            <td class="text-center">
                <button type="button" class="btn btn-info btn-sm" data-toggle="modal" data-target="#GuideDetails">View</button>
                <div class="modal fade" id="GuideDetails" role="dialog">
                    <div class="modal-dialog">
                        <!-- Modal content-->
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                <h3 class="modal-title" style="font-weight: bold;">Tour Details</h3>
                            </div>
                            <div class="modal-body">
                                Payment Made: $ 150
                                <br />
                                MeetUp Time: 1000
                                <br />
                                MeetUp Location: Khatib MRT Station
                            </div>
                            <div class="modal-footer">
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
                        </div>

                    </div>
                </div>

            </td>
            <td>
                <p data-placement="top" class="text-center" data-toggle="tooltip" title="Proof">
                    <button class="btn btn-info btn-xs"><a class="glyphicon glyphicon-qrcode" href="GuidedQRpage.aspx"></a></button>
                </p>
            </td>
        </tr>
    </table>
    <asp:Button ID="BtnBackToMain" runat="server" Text="Back" class="btn btn-primary centraliseItem" OnClick="BtnBackToMain_Click" />
</asp:Content>

