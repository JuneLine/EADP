<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelfplanConfirmation.aspx.cs" Inherits="SREX.SelfplanConfirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row body-container">
        <div class="well text-center">
                <h3>Trip to Singapore</h3>
            </div>
            <div class="col-sm-6">
                <div class="leftdivbox ">
                    <h3>Personal Particulars</h3>
                    <br />
                    <div class="form-group">
                        <label>Name</label>
                        <input type="text" class="form-control" placeholder="Name">
                    </div>
                    <br />
                    <div class="form-group">
                        <label>E-mail</label>
                        <input type="email" class="form-control" placeholder="Email Address">
                    </div>
                    <br />
                    <div class="form-group">
                        <label>Contact</label>
                        <input type="number" class="form-control" placeholder="Contact Number">
                    </div>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="toprightbox ">
                    <h3>Tour Details</h3>
                    <br />
                    <p>
                        <h4>A day in Singapore</h4>
                        MeetUp Time: 1000<br />
                        MeetUp Location: Khatib MRT Station<br />
                        Date selected: 10/10/2020
                    </p>
                </div>
                <hr />
                <div class="btmrightbox ">
                    <h4>Purchase</h4>
                    <div style="border-bottom:0.5px solid black;">
                        Cost of tour guide: $20 SGD <br />
                        <br />
                    </div>
                    <br />
                    <p>Total Cost:<span>$20 SGD</span></p>
                    <br />
                    <p>Further information will be sent to your email</p>
                    <p>Please confirm your plan down below</p>
                    <button type="button" class="btn btn-primary" style="float:right;margin: 1%" onclick="window.location.href='PlanningHistory.aspx'">Purchase</button>
                </div>
            </div>
        </div>
    <hr />
    <div class="row body-container-own col-sm-12 col-lg-12">
            <p>
                Date Selected: 10/10/2020<br />
                MeetUp Location: Khatib MRT Station
            </p>

            <br />
            <table class="table table-hover table-bordered col-sm-12 text-center" style="font-size: 16px;">
                <tr>
                    <th class="col-sm-3">Time</th>
                    <th class="col-sm-9">Activity</th>
                </tr>
                <tr>
                    <td>1000-1100</td>
                    <td>Singapore Zoo<br />
                        
                    </td>
                </tr>
                <tr>
                    <td>1100-1200</td>
                    <td rowspan="2">
                        Singapore Zoo
                    </td>
                </tr>
                <tr>
                    <td>1200-1300</td>
                </tr>
                <tr>
                    <td>1300-1400</td>
                    <td>Lunch</td>
                </tr>
                <tr>
                    <td>1400-1500</td>
                    <td rowspan="2">Botanic Garden</td>
                </tr>
                <tr>
                    <td>1500-1600</td>
                </tr>
                <tr>
                    <td>1600-1700</td>
                    <td>Botanic Garden</td>
                </tr>
                <tr>
                    <td style="height: 38px">1700</td>
                    <td style="height: 38px">End Of Tour</td>
                </tr>
            </table>
        <br />
        <br />
        <br />
        </div>
</asp:Content>
