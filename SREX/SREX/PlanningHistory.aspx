<%@ Page Title="Planning History" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlanningHistory.aspx.cs" Inherits="SREX.PlanningHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container">
        <div class="page-header">
        <h1 class="text-center">Self Plan histories</h1>
        </div>
    </div>
    <div class="list-group">
        <div class="list-group-item list-group-item-action flex-column align-items-start">
            <div class="d-flex w-100 justify-content-between">
                <h5 class="mb-1">Singapore trip 1</h5>
                <small style="color:red;">Guided</small>
                <br />
                <small>11/9/2019</small>
            </div>
                <p class="mb-1">Fill in your trip details here</p>
                <p class="mb-1">Fill in your trip details here2</p>
            <div class="row">
                <button type="button" class="btn btn-primary" style="float:right;margin: 1%">View</button>
            </div>
        </div>
        <div class="list-group-item list-group-item-action flex-column align-items-start">
            <div class="d-flex w-100 justify-content-between">
                <h5 class="mb-1">Singapore trip 2</h5>
                <small style="color:red;"> Not Guided</small>
                <br />
                <small class="text-muted">11/10/2019</small>
            </div>
            <p class="mb-1">Fill in your trip details here3</p>
            <p class="mb-1">Fill in your trip details here3</p>
            <div class="row">
                <button type="button" class="btn btn-primary" style="float:right;margin: 1%">Edit</button>
            </div>
        </div>
        <div class="list-group-item list-group-item-action flex-column align-items-start">
            <div class="d-flex w-100 justify-content-between">
                <h5 class="mb-1">Singapore trip 3</h5>
                <small style="color:red;">Guided</small>
                <br />
                <small class="text-muted">11/11/2019</small>
            </div>
            <p class="mb-1">Fill in your trip details here4</p>
            <p class="mb-1">Fill in your trip details here4</p>
            <div class="row">
                <button type="button" class="btn btn-primary" style="float:right;margin: 1%">View</button>
            </div>
        </div>
    </div>
</asp:Content>
