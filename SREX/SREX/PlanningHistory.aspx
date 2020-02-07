<%@ Page Title="Planning History" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlanningHistory.aspx.cs" Inherits="SREX.PlanningHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/selfPlan.css" rel="stylesheet" />
    <div class="container">
        <div class="page-header well">
            <h1 class="text-center">Self Plan histories</h1>
        </div>
    </div>
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
                         
                    </div>
                </div>
        </div>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
