<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="selfplanView.aspx.cs" Inherits="SREX.selfplanView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
            <div class="page-header">
                <h1 class="text-center">Singapore trip (#)</h1>
            </div>
    </div>
    <div class="d-flex w-100 justify-content-between">
                <h5 class="mb-1">Singapore trip 2</h5>
                <small style="color:red;"> Not Guided</small>
                <br />
                <small class="text-muted">11/10/2019</small>
            </div>
            <div class="col-sm-12 col-lg-12">
                <div class="row">
                    <table class="table">
                        <thead class="thead-dark">
                            <tr>
                                <th scope="col" class="col-sm-2 col-lg-2">Timings</th>
                                <th scope="col" class="col-sm-10 col-lg-10">Activities</th>
                            </tr>
                        </thead>
                        <tbody>
                        <tr>
                            <th scope="row">10am - 11am</th>
                            <td colspan="3"><p>Breakfast @ my house</p></td>
                        </tr>
                        <tr>
                            <th scope="row">11am - 12am</th>
                            <td colspan="3"><p>Singapore Zoo</p></td>
                        </tr>
                        <tr>
                            <th scope="row">12am - 1pm</th>
                            <td colspan="3"><p>Lunch @ your house</p></td>
                        </tr>
                        <tr>
                            <th scope="row">1pm - 2pm</th>
                            <td colspan="3"><p>Botanic Gardens</p></td>
                        </tr>
                        <tr>
                            <th scope="row">2pm - 3pm</th>
                            <td colspan="3"><p>Picnic at the grass patch</p></td>
                        </tr>
                        <tr>
                            <th scope="row">3pm - 4pm</th>
                            <td colspan="3"><p>-</p></td>
                        </tr>
                        <tr>
                            <th scope="row">4pm - 5pm</th>
                            <td colspan="3"><p>-</p></td>
                        </tr>
                        <tr>
                            <th scope="row">5pm - 6pm</th>
                            <td colspan="3"><p>Resort World Sentosa</p></td>
                        </tr>
                        <tr>
                            <th scope="row">6pm - 7pm</th>
                            <td colspan="3"><p>Dinner at SteakHouse</p></td>
                        </tr>
                        <tr>
                            <th scope="row">7pm - 8pm</th>
                            <td colspan="3"><p>Sentosa</p></td>
                        </tr>
                        </tbody>
                    </table><p class="mb-1"></p>
                    </div>
                <br />
                <br />
                <br />
                <br />
                </div>
</asp:Content>
