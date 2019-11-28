<%@ Page Title="Guided Tours" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuidedTour.aspx.cs" Inherits="SREX.PlannedTour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <div class="text-center font24 body-container-own">
        <div class="well" style="margin-top: 3%;">
            <h1>Our Plans</h1>
        </div>
        <div style="margin-bottom: 3%">
            <asp:Button runat="server" class="btn btn-primary buttonRight" ID="btnToGuideHist" Text="History" OnClick="btnToGuideHist_Click" />
        </div>
        <br />
        <br />
        <div class="container">
            <div class="row">
                <div class="col-sm-6">

                    <div class="panel panel-success">
                        <div class="panel-heading panelHeader">Day Tour At Singapore ZOO</div>
                        <a href="GuidedTourDetails">
                            <div class="panel-body">
                                <asp:Image runat="server" ImageUrl="~/Pictures/SingaporeZoo.jpg" Height="300px" Width="550px" />
                            </div>
                        </a>
                        <div class="panel-footer">
                            Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption 
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption
                        </div>
                    </div>


                    <div class="panel panel-success">
                        <div class="panel-heading panelHeader">Garden By The Bay Walk Around</div>
                        <a href="#">
                            <div class="panel-body">
                                <asp:Image runat="server" ImageUrl="~/Pictures/GBTB.jpg" Height="300px" Width="550px" />
                            </div>
                        </a>
                        <div class="panel-footer">
                            Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption 
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption
                        </div>
                    </div>

                </div>

                <div class="col-sm-6">

                    <div class="panel panel-success">
                        <div class="panel-heading panelHeader">Bird Park at Jurong</div>
                        <a href="#">
                            <div class="panel-body">
                                <asp:Image runat="server" ImageUrl="~/Pictures/JurongBirdPark.jpg" Height="300px" Width="550px" />
                            </div>
                        </a>
                        <div class="panel-footer">
                            Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption 
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption
                        </div>
                    </div>


                    <div class="panel panel-success">
                        <div class="panel-heading panelHeader">USS Tour</div>
                        <a href="#">
                            <div class="panel-body">
                                <asp:Image runat="server" ImageUrl="~/Pictures/USS.jpg" Height="300px" Width="550px" />
                            </div>
                        </a>
                        <div class="panel-footer">
                            Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption 
                                Caption Caption Caption Caption Caption Caption Caption Caption Caption Caption
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <div>
            <%--<asp:Button ID="BtnAddTours" runat="server" Text="Add" class="btn btn-primary addEvents" />--%>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
