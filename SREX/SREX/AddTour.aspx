﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddTour.aspx.cs" Inherits="SREX.AddTour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <br />
    <div class="body-container-own">
        <div class="well text-center">
            <h2><b>Add Tour</b></h2>
        </div>
        <div class="container" style="padding: 5%;">
            <fieldset>
                <div class="col-sm-6">
                    <div class="form-group">
                        <label for="AttractionName">Tour Name: </label>
                        <asp:TextBox runat="server" ID="tbTourName" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <div>
                            <label for="tbDateOfTour">Date Of Tour: </label>
                            <asp:TextBox runat="server" ID="tbDateOfTour" CssClass="form-control" placeholder="DD/MM/YYYY"></asp:TextBox>
                        </div>
                        <div>
                            <label for="TourPicture">Picture: </label>
                            <asp:FileUpload runat="server" ID="FileTourPicture" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="TourCaption">Tour Caption: </label>
                        <asp:TextBox runat="server" ID="tbTourCaption" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row form-group">
                        <div class="col-sm-4">
                            <label for="DropDownListTime">Meet Up Time: </label>
                            <asp:DropDownList ID="DropDownListmeetTime" runat="server" CssClass="form-control">
                                <asp:ListItem>0900</asp:ListItem>
                                <asp:ListItem>1000</asp:ListItem>
                                <asp:ListItem>1100</asp:ListItem>
                                <asp:ListItem>1200</asp:ListItem>
                                <asp:ListItem>1300</asp:ListItem>
                                <asp:ListItem>1400</asp:ListItem>
                                <asp:ListItem>1500</asp:ListItem>
                                <asp:ListItem>1600</asp:ListItem>
                                <asp:ListItem>1700</asp:ListItem>
                                <asp:ListItem>1800</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-8">
                            <label for="tbMeetUpLocation">Meet Up Location: </label>
                            <asp:TextBox runat="server" ID="tbLocation" CssClass="form-control" placeholder="E.g Khatib MRT"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row form-group">
                        <div class="col-sm-4">
                            <label for="tbAdultCost" class="label-inline">Adult Price: </label>
                            <asp:TextBox runat="server" ID="tbAdultCost" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-sm-4">
                            <label for="tbChildCost">Child Price </label>
                            <asp:TextBox runat="server" ID="tbChildCost" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-sm-4">
                            <label for="tbSeniorCost">Senior Price: </label>
                            <asp:TextBox runat="server" ID="tbSeniorCost" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6">
                    <label>Time Schedule</label>
                    <asp:Table runat="server" CssClass="table table-bordered table-hover">
                        <asp:TableHeaderRow>
                            <asp:TableCell>
                            Time
                            </asp:TableCell>
                            <asp:TableCell>
                            Activity
                            </asp:TableCell>
                        </asp:TableHeaderRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime1" runat="server">
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity1"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime2" runat="server">
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity2"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime3" runat="server">
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity3"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime4" runat="server">
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity4"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime5" runat="server">
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity5"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime6" runat="server">
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity6"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime7" runat="server">
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity7"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
            </fieldset>
        </div>
        <div style="text-align: center">
<%--          <input type="button" class="btn btn-primary" value="Add Places" data-toggle="modal" data-target="#ConfirmAdd" />--%>
            <asp:Button runat="server" Text="Confirm" CssClass="btn btn-primary" ID="AddTourConfirmation" OnClick="AddTourConfirmation_Click" />
        </div>
    </div>
    <%--<div class="modal fade" id="ConfirmAdd" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true" runat="server">
        <div class="modal-dialog" style="margin-top: 10%;" role="document">
            <div class="modal-content form">
                <div class="modal-header">
                    <h2>Confirmation</h2>
                </div>
                <div class="modal-body">
                    Tour Name: <asp:Label runat="server" ID="lblTourName"></asp:Label>
                    Tour Caption: <asp:Label runat="server" ID="lblTourCaption"></asp:Label>
                    Tour Picture: 
                    <asp:Label runat="server"></asp:Label>
                    <asp:Label runat="server"></asp:Label>
                    <asp:Label runat="server"></asp:Label>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button runat="server" ID="AddNewTour" Text="Confirm" CssClass="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>--%>
</asp:Content>
