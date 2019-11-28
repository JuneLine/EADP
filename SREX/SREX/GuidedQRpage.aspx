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
                <img src="https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png" style="height: 75%; width: 75%; margin-left: 40%" />
            </div>
            <div class="col-lg-8 col-md-12 col-sm-12">
                <table style="margin-top: 10%; margin-left: 20%; font-size: 1.5em;">
                    <tr>
                        <td style="font-weight: bold;">Name:
                        </td>
                        <td>&nbsp Marcus Chua
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">Date Of Birth:
                        </td>
                        <td>&nbsp 06/08/2001
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">Passport Number:
                        </td>
                        <td>&nbsp K0123456E
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="container body-container-own">
        <div class="row" style="margin-bottom: 2.5%;">
            <div class="col-sm-6" style="font-size: 1.2em;">
                MeetUp Time: <b>1000</b><br />
                MeetUp Location: <b>Khatib MRT Station</b>
            </div>

            <div class="col-sm-6" style="font-size: 1.2em;">
                Total Cost: <b>$175.50</b>
                <br />
                Tickets Bought: <b>2 Adults, 1 Child</b><br />
            </div>
        </div>
        <div class="row">
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
        </div>
    </div>
</asp:Content>
