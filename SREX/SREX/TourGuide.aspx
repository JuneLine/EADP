<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TourGuide.aspx.cs" Inherits="SREX.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <nav class="navbar navbar-inverse bg-light" style="margin-bottom:0px;">
        <a class="navbar-brand active" href="TourGuide">Plans you can guide</a>
        <a class="navbar-brand" href="viewAllGuidingTour">View plans you are guiding</a>
    </nav>
    <div class="jumbotron" style="margin: 0px;">
                <h1 class="text-center">Available Tours for you to guide!</h1>
        <p class="lead text-center">Here are the tours that you can guide</p>
    </div>

    <div class="row">
        <div class="input-group col-sm-12 col-lg-12">
        <asp:TextBox ID="TbSearch" class="form-control" placeholder="Search for..." runat="server"></asp:TextBox>
        <span class="input-group-btn">
            <asp:Button ID="ButtonSearchName" runat="server" Text="Go!" class="btn btn-default" OnClick="ButtonSearchName_Click"/>
        </span>
    </div>

        <div class="col-sm-4 col-lg-4">
            <asp:Button ID="ButtonAll" style="padding:5px; margin:5px;" class="btn btn-primary" runat="server" Text="View all" OnClick="ButtonAll_Click"/>
        </div>
    </div>
<%--    <div class="col-sm-12 col-lg-12 text-center" style="padding:2%;" runat="server">
        <asp:GridView ID="GvTD" runat="server" AutoGenerateColumns="False" Height="120px" Width="100%" CssClass="table table-striped" OnSelectedIndexChanged="GvTD_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="UniqueId" HeaderText="UniqueId"/>
                        <asp:BoundField DataField="UserName" HeaderText="Username"/>
                        <asp:BoundField DataField="Title" HeaderText="Title" />
                        <asp:BoundField DataField="Date" HeaderText="Date"/>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
     </div>--%>
    <div class="col-sm-12 col-lg-12 text-center" runat="server">
        <asp:DataList runat="server" ID="DataListPlans" RepeatColumns="2" Width="100%">
        <ItemTemplate>
            <div class="thumbnail" style="margin: 1.5%;">
                <div class="caption" style="">
                    <h4><%#Eval("Username") %></h4>
                    <p><%#Eval("Title") %></p>
                    <p><%#Eval("Date") %></p>
                    <button class="btn btn-info">
                        <a href="TourGuideConfirmation?PlanId=<%#Eval("UniqueId") %>" id="ViewPlan">View</a>
                    </button>
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
    <br />
    <br />
    <br />
    <br />
</asp:Content>
