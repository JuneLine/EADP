<%@ Page Title="Payment" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuidedPayment.aspx.cs" Inherits="SREX.GuidedPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <div class="container-fluid body-container-own">
        <br />
        <div class="well text-center">
            <h1>Payment</h1>
        </div>
        <br />
        <div class="row body-container-own">
            <div class="col-sm-6">
                <div class="leftdivbox ">
                    <h3>Personal Particulars</h3>
                    <br />
                    <div class="form-group">
                        <label class="input-lg">Name</label>
                        <input type="text" class="form-control input-lg" placeholder="Name">
                    </div>
                    <br />
                    <div class="form-group">
                        <label class="input-lg">Passport Number</label>
                        <input type="text" class="form-control input-lg" placeholder="Passport Number">
                    </div>
                    <br />
                    <div class="form-group">
                        <label class="input-lg">E-mail</label>
                        <input type="email" class="form-control input-lg" placeholder="Email Address">
                    </div>
                    <br />
                    <div class="form-group">
                        <label class="input-lg">Contact</label>
                        <input type="number" class="form-control input-lg" placeholder="Contact Number">
                    </div>
                </div>
            </div>
            <div class="col-sm-6" style="font-size: 1.2em;">
                <div class="toprightbox ">
                    <h3>Tour Details</h3>
                    <br />
                    <h4>Tour Package: <b>Day Your At Singapore ZOO</b></h4>
                    <p style="font-size: 1.05em;">
                        MeetUp Time: <b>1000</b>
                        <br />
                        MeetUp Location: <b>Khatib MRT Station</b>
                    </p>
                </div>
                <hr />
                <div class="btmrightbox" style="font-size: 1.05em;">
                    <h3>Purchase</h3>
                    <div>
                        <div class="dropdown">
                            Quantity:
                            <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">
                                Ticket Quantities
                                <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu" style="right: auto; left: 75px;">
                                <li>
                                    <input type="button" value="+" class="btn" />&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <span>0</span> Child
                                    <input type="button" value="-" class="btn" style="float: right;" />
                                </li>
                                <li>
                                    <input type="button" value="+" class="btn" />&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <span>0</span> Adult
                                    <input type="button" value="-" class="btn" style="float: right;" />
                                </li>
                                <li>
                                    <input type="button" value="+" class="btn" />&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <span>0</span> Senior
                                    <input type="button" value="-" class="btn" style="float: right;" />
                                </li>
                            </ul>
                        </div>
                        <br />
                        <table class="table">
                            <tr>
                                <td>Cost:</td>
                                <td>$150.00</td>
                            </tr>
                            <tr>
                                <td>GST(7%):</td>
                                <td>$10.50</td>
                            </tr>
                            <tr style="border-bottom: solid black;">
                                <td>Service Charge(10%):</td>
                                <td>$15.00</td>
                            </tr>
                            <tr>
                                <td>Total Cost:</td>
                                <td>$175.50</td>
                            </tr>
                        </table>
                        <asp:Button runat="server" Text="Purchase" class="btn btn-primary buttonRight" Style="margin-top: 2%" ID="btnBuyTicket" OnClick="btnBuyTicket_Click" />
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
