<%@ Page Title="Guided Tours" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlannedTour.aspx.cs" Inherits="SREX.PlannedTour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <div class="text-center font24 body-container-own">
        <div class="well" style="margin-top: 3%;">
            <h1>Our Plans</h1>
        </div>
        <div style="margin-bottom:3%">
            <asp:Button runat="server" Text="History" class="btn btn-primary buttonRight" />
        </div>
        <br />
        <br />
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    <a href="GuidedTourDetails">
                        <div class="panel panel-success">
                            <div class="panel-heading panelHeader">Day Tour At Singapore ZOO</div>
                            <div class="panel-body">
                                <asp:Image runat="server" ImageUrl="~/Pictures/SingaporeZoo.jpg" Height="200px" Width="350px" />
                            </div>
                            <div class="panel-footer">
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption 
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption
                            </div>
                        </div>
                    </a>
                    <a href="#">
                        <div class="panel panel-success">
                            <div class="panel-heading panelHeader">Garden By The Bay Walk Around</div>
                            <div class="panel-body">
                                <asp:Image runat="server" ImageUrl="~/Pictures/GBTB.jpg" Height="200px" Width="350px" />
                            </div>
                            <div class="panel-footer">
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption 
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption
                            </div>
                        </div>
                    </a>
                </div>

                <div class="col-sm-6">
                    <a href="#">
                        <div class="panel panel-success">
                            <div class="panel-heading panelHeader">Bird Park at Jurong</div>
                            <div class="panel-body">
                                <asp:Image runat="server" ImageUrl="~/Pictures/JurongBirdPark.jpg" Height="200px" Width="350px" />
                            </div>
                            <div class="panel-footer">
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption 
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption
                            </div>
                        </div>
                    </a>
                    <a href="#">
                        <div class="panel panel-success">
                            <div class="panel-heading panelHeader">USS Tour</div>
                            <div class="panel-body">
                                <asp:Image runat="server" ImageUrl="~/Pictures/USS.jpg" Height="200px" Width="350px" />
                            </div>
                            <div class="panel-footer">
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption 
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption
                            </div>
                        </div>
                    </a>
                </div>
            </div>
        </div>
        <div>
            <%--<asp:Button ID="BtnAddTours" runat="server" Text="Add" class="btn btn-primary addEvents" />--%>
        </div>
        <br />
        <br />
    </div>
</asp:Content>
