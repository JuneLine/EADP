<%@ Page Title="Planning History" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlanningHistory.aspx.cs" Inherits="SREX.PlanningHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/selfPlan.css" rel="stylesheet" />
    <br />
    <nav class="navbar navbar-inverse bg-light" style="margin-bottom:0px;">
        <a class="navbar-brand active" href="SelfPlanMain">Plan your tours here!</a>
        <a class="navbar-brand" href="planningHistory">View your created plans</a>
    </nav>
    <div class="jumbotron" style="margin: 0px;">
                <h1 class="text-center">Plan histories</h1>
        <p class="lead text-center">View your own created plans</p>
    </div>
    <br />
    <div class="body-container-own list-group col-sm-12 col-lg-12">
        <div class="panel panel-info" style="width: 100%">
                    <div class="panel-heading">
                        <h3 class="panel-title">Existing destinations</h3>
                    </div>
                    <div class="panel-body">
                        <asp:GridView ID="GvTD" runat="server" AutoGenerateColumns="False" Height="120px" Width="100%" CssClass="table table-striped" OnSelectedIndexChanged="GvTD_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="UniqueId" HeaderText="UniqueId"/>
                        <asp:BoundField DataField="Title" HeaderText="Title" />
                        <asp:BoundField DataField="Date" HeaderText="Date"/>
                        <asp:BoundField DataField="Hire" HeaderText="Hire"/>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                        <div class="row text-center col-lg-12 col-sm-12">
                            <asp:Label ID="LabelNothing" runat="server" Text="" CssClass="text-center" style="text-align:center;"></asp:Label>
                        </div>
                    </div>
                </div>
        </div>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
