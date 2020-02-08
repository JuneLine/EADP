<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewAllGuidingTours.aspx.cs" Inherits="SREX.viewAllGuidingTours" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <nav class="navbar navbar-inverse bg-light" style="margin-bottom:0px;">
        <a class="navbar-brand active" href="TourGuide">Plans you can guide</a>
        <a class="navbar-brand" href="viewAllGuidingTour">View plans you are guiding</a>
    </nav>
    <div class="jumbotron" style="margin: 0px;">
                <h1 class="text-center">Your assigned tours</h1>
        <p class="lead text-center">Here are the tours that you are assigned to!</p>
    </div>
    <br />
    <div class="col-sm-12 col-lg-12 text-center" runat="server">
        <asp:DataList runat="server" ID="DataListPlans" RepeatColumns="1" Width="100%">
        <ItemTemplate>
            <div class="thumbnail">
                <div class="caption">
                   <h4> <%#Eval("Title") %> </h4>
                    <p><%#Eval("Username") %></p>
                    <p><%#Eval("Date") %></p>
                    <a href="TourGuideViewPlans?PlanId=<%#Eval("UniqueId") %>" class="btn btn-primary" id="ViewPlan">View</a>
                    </div>
                </div>
            </div>
        </ItemTemplate>
        </asp:DataList>
        <br />
    <br />
    <br />
    <br />
    <br />
    </div>

</asp:Content>
