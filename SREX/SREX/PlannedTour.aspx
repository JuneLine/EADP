<%@ Page Title="Guided Tours" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlannedTour.aspx.cs" Inherits="SREX.PlannedTour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center font24">
        <div class="well" style="margin-top: 3%;">
            <h1>Our Plans</h1>
        </div>
        <div class="Rightfloat">
            <asp:Button ID="BtnAddTours" runat="server" Text="Add" class="btn btn-primary" />
        </div>
        <br />
        <br />
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    <div class="panel panel-success">
                        <div class="panel-heading">BLACK FRIDAY DEAL</div>
                        <div class="panel-footer">Buy 50 mobiles and get a gift card</div>
                    </div>
                    <div class="panel panel-success">
                        <div class="panel-heading">BLACK FRIDAY DEAL</div>
                        <div class="panel-footer">Buy 50 mobiles and get a gift card</div>
                    </div>
                </div>

                <div class="col-sm-6">
                    <div class="panel panel-success">
                        <div class="panel-heading">BLACK FRIDAY DEAL</div>
                        <div class="panel-footer">Buy 50 mobiles and get a gift card</div>
                    </div>
                    <div class="panel panel-success">
                        <div class="panel-heading">BLACK FRIDAY DEAL</div>
                        <div class="panel-footer">Buy 50 mobiles and get a gift card</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
