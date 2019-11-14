<%@ Page Title="Guided Tours" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlannedTour.aspx.cs" Inherits="SREX.PlannedTour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center font24">
        <h1>Our Plans</h1>
        <div class="Rightfloat">
            <asp:Button ID="BtnAddTours" runat="server" Text="Add" class="btn btn-primary" />
        </div>
        <br />
        <br />
        <div class="container-fluid">
            <div class="col-sm-6">
                <div class="well wellBox">
                    <div class="caption">
                        Day Tour At The West
                    </div>
                </div>
                <div class="well">
                    <div class="caption">
                        Day Tour Around Central
                    </div>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="well">
                    <div class="caption">
                        Day Tour In the North
                    </div>
                </div>
                <div class="well">
                    <div class="caption">
                        Journey To Conney Island
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
