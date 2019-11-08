<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SREX._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 class="text-center">Welcome</h1>
        <p class="lead text-center">"Travel Safe, Travel Far, and Travel Smart."</p>
    </div>
    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-6 col-md-6 col-sm-6 text-center leaveSpace">
                <a href="Shopping">
                    <i class="fa fa-shopping-cart shoppingCart"></i>
                </a>
                <h3>Shopping</h3>
            </div>
            <div class="col-lg-6 col-md-6 col-sm-6 text-center leaveSpace">
                <a href="PlanningMain">
                    <i class="fa fa-file-text-o fileText"></i>
                </a>
                <h3>Planning</h3>
            </div>
        </div>
    </div>

</asp:Content>
