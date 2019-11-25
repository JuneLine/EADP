<%@ Page Title="Tour Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuidedTourDetails.aspx.cs" Inherits="SREX.GuidedTourDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <div class="container-fluid">
        <div class="row body-container-own">
            <br />
            <div class="well text-center">
                <h2><b>Day Tour At Singapore ZOO</b></h2>
            </div>
            <p style="font-size:large">
                MeetUp Time: <b>1000</b><br />
                MeetUp Location: <b>Khatib MRT Station</b><br />
                Estimated Cost: <b>SGD68 per pax</b>
            </p>

            <h3>Day Schedule</h3>
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
                    <td rowspan="2">
                        Wild Discoverer Tour
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
            <asp:Button ID="BtnPurchaseTicks" runat="server" class="btn btn-primary centraliseItem" OnClick="BtnPurchaseTicks_Click" Text="Buy" />
        </div>
    </div>
</asp:Content>
