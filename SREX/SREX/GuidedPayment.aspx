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
                        <label>Name</label>
                        <input type="text" class="form-control" placeholder="Name">
                    </div>
                    <br />
                    <div class="form-group">
                        <label>Passport Number</label>
                        <input type="text" class="form-control" placeholder="Passport Number">
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
                        <h4>Tour Package Bought: Day Your At Singapore ZOO</h4>
                        MeetUp Time: 1000<br />
                        MeetUp Location: Khatib MRT Station
                    </p>
                </div>
                <hr />
                <div class="btmrightbox ">
                    <h4>Purchase</h4>
                    <div style="border-bottom: 0.5px solid black;">
                        <%--Quantity: 
                        <div style="border:1px solid black; width:fit-content; padding:0.5%;">
                            <input type="button" value="+" class="btnplusminus"/>&nbsp<span>0</span>&nbsp<input type="button" value="-" class="btnplusminus"/>
                        </div>--%>
                        <div class="dropdown">
                            <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">
                                Dropdown Example
                                <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Child</a></li>
                                <li><a href="#">Adult</a></li>
                                <li><a href="#">Senior Citizen</a></li>
                            </ul>
                        </div>
                        Cost: Reeee
                        <br />
                        Service Charge(10%): Reeee
                        <br />
                        GST(7%): Reeee
                    </div>
                    <p>Total Cost:<span>E yes</span></p>

                    <asp:Button runat="server" Text="Purchase" class="btn btn-primary buttonRight" Style="margin-top: 2%" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
