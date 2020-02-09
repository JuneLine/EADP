<%@ Page Title="Payment" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuidedPayment.aspx.cs" Inherits="SREX.GuidedPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <div class="container-fluid body-container-own">
        <br />
        <div class="well text-center">
            <h1>Payment</h1>
        </div>
        <br />
        <div class="container">
            <div class="row">
                <div class="col-sm-4">
                    <div>
                        <h2>Personal Particulars</h2>
                        <br />
                        <div class="form-group">
                            <label for="tbUserName">Name: <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Fill In Your Name" ForeColor="red" ControlToValidate="tbUserName">*</asp:RequiredFieldValidator></label>
                            <asp:TextBox runat="server" class="form-control" ID="tbUserName"></asp:TextBox>                            
                        </div>
                        <br />
                        <div class="form-group">
                            <label for="tbUserEmail">E-mail: <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Fill In Your Email" ForeColor="red" ControlToValidate="tbUserEmail">*</asp:RequiredFieldValidator></label>
                            <asp:TextBox runat="server" class="form-control" ID="tbUserEmail"></asp:TextBox>
                        </div>
                        <br />
                        <div class="form-group">
                            <label for="tbUserContact">Contact: <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Fill In Your Contact" ForeColor="red" ControlToValidate="tbUserContact">*</asp:RequiredFieldValidator></label>
                            <asp:TextBox runat="server" class="form-control" ID="tbUserContact"></asp:TextBox>
                            <asp:Label runat="server" ID="lbltourname" Visible="false"></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-sm-8" style="font-size: 1.2em; padding-left: 5%;">
                    <h2>Tour Details</h2>
                    <div class="row">
                        <asp:DataList ID="DataListTourInfo" runat="server" RepeatLayout="Flow">
                            <HeaderTemplate>
                                <h3>Information</h3>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <div class="row">
                                    <div class="col-sm-5">
                                        <h4>Tour Package:</h4>
                                        &nbsp&nbsp&nbsp&nbsp<b><%#Eval("tourName") %></b>
                                    </div>
                                    <div class="col-sm-7">
                                        <h4>Date Of Tour:</h4>
                                        &nbsp&nbsp&nbsp&nbsp<b><%#Eval("Date") %></b>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col-sm-5">
                                        <h4>Meet at:</h4>
                                        &nbsp&nbsp&nbsp&nbsp<b><%#Eval("meetUpTime") %></b> at <b><%#Eval("meetUpLocation") %></b>
                                    </div>
                                    <div class="col-sm-7">
                                        <h4>Ticket Price:</h4>
                                        <div class="col-sm-3">
                                            <h4>Adult:
                                    <asp:Label runat="server" ID="lblAdultCost">SGD<%#Eval("AdultCost") %></asp:Label>
                                            </h4>
                                        </div>
                                        <div class="col-sm-3">
                                            <h4>Child:
                                    <asp:Label runat="server" ID="lblChildCost">SGD<%#Eval("ChildCost") %></asp:Label>
                                            </h4>
                                        </div>
                                        <div class="col-sm-3">
                                            <h4>Senior:
                                    <asp:Label runat="server" ID="lblSeniorCost">SGD<%#Eval("SeniorCost") %> </asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </div>
            </div>
            <div class="row" style="font-size: 1.05em;">
                <h3>Purchase</h3>
                <div class="col-sm-5">
                    <table class="table text-center">
                        <tr>
                            <th></th>
                            <th>Cost</th>
                            <th>Quantity</th>
                            <th>Total</th>
                        </tr>
                        <tr>
                            <td>Adult</td>
                            <td>SGD<asp:Label runat="server" ID="AdultPerTicket"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="tbAdultQuantity" Text="0" CssClass="form-control"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblAdultTotal" Text="0"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Child</td>
                            <td>SGD<asp:Label runat="server" ID="ChildPerTicket"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="tbChildQuantity" Text="0" CssClass="form-control"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblChildTotal" Text="0"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Senior</td>
                            <td>SGD<asp:Label runat="server" ID="SeniorPerTicket"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="tbSeniorQuantity" Text="0" CssClass="form-control"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblSeniorTotal" Text="0"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="col-sm-5">
                    <br />
                    <table class="table">
                        <tr>
                            <td>Cost:</td>
                            <td>
                                <asp:Label runat="server" ID="lblTotalAmount" Text="0"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>GST(7%):</td>
                            <td>
                                <asp:Label runat="server" ID="lblGST" Text="0"></asp:Label></td>
                        </tr>
                        <tr style="border-bottom: solid black;">
                            <td>Service Charge(10%):</td>
                            <td>
                                <asp:Label runat="server" ID="lblService" Text="0"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Total Cost:</td>
                            <td>
                                <asp:Label runat="server" ID="lblFinalAmount" Text="0"></asp:Label></td>
                        </tr>
                    </table>
                </div>
                <br />
                <br />
                <asp:Button runat="server" CssClass="btn btn-default" Text="Clear" ID="btnClear" OnClick="btnClear_Click" />
                <asp:Button runat="server" CssClass="btn btn-success" Text="Calculate" ID="btnCalculateTotal" OnClick="btnCalculateTotal_Click" />
            </div>
        </div>
        <div class="text-center">
            <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Confirm</button>
        </div>
    </div>
    <div class="modal fade" id="myModal" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Confirmation</h4>
                </div>
                <div class="modal-body text-center">
                    <p>Confirm The Purchase?</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    <asp:Button runat="server" Text="Purchase" class="btn btn-primary" ID="btnBuyTicket" OnClick="btnBuyTicket_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
