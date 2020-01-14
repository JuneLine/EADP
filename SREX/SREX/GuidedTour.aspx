<%@ Page Title="Guided Tours" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuidedTour.aspx.cs" Inherits="SREX.PlannedTour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <div class="text-center font24 body-container-own">
        <div class="well" style="margin-top: 3%;">
            <h1>Our Plans</h1>
        </div>
        <div style="margin-bottom: 3%">
            <asp:Button runat="server" CssClass="btn btn-primary buttonRight" ID="btnToGuideHist" Text="History" OnClick="btnToGuideHist_Click" />
        </div>
        <br />
        <br />
        <div class="container">
            <div class="row">
                <asp:DataList ID="DataListTours" runat="server" RepeatColumns="2" RepeatDirection="Horizontal" CellSpacing="1">
                    <ItemTemplate>
                        <div class="panel panel-success" style="margin: 10px;">
                            <div class="panel-heading panelHeader"><%#Eval("tourName") %></div>
                            <a href="GuidedTourDetails?tourId=<%#Eval("tourId") %>">
                                <div class="panel-body">
                                    <asp:Image runat="server" ImageUrl='<%# String.Format("Pictures/{0}", Eval("tourPic") ) %>' Height="300px" Width="550px" />
                                </div>
                            </a>
                            <div class="panel-footer">
                                <%#Eval("tourCaption") %>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
        <div>
            <asp:Button runat="server" ID="BtnAddTours" CssClass="btn btn-primary addEvents" OnClick="BtnAddTours_Click" Text="Add Tour" style="display:none;"/>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
