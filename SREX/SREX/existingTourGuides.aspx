<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="existingTourGuides.aspx.cs" Inherits="SREX.existingTourGuides" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <nav class="navbar navbar-inverse bg-light" style="margin-bottom:0px;">
        <a class="navbar-brand active" href="AdminApplication">View current tour guide applications</a>
        <a class="navbar-brand" href="existingTourGuides">View existing tour guides</a>
    </nav>
    <div class="jumbotron" style="margin: 0px;">
                <h1 class="text-center">Existing tour guides</h1>
        <p class="lead text-center">Here are the current tour guides that we have</p>
    </div>
    <div class="col-sm-12 col-lg-12 text-center" style="padding:2%;" runat="server">
        <asp:GridView ID="GvTD" runat="server" AutoGenerateColumns="False" Height="120px" Width="100%" CssClass="table table-striped" OnSelectedIndexChanged="GvTD_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="UniqueId" HeaderText="ID"/>
                        <asp:BoundField DataField="UserName" HeaderText="Username"/>
                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        <asp:BoundField DataField="EmailAddr" HeaderText="EmailAddr"/>
                        <asp:CommandField ShowSelectButton="True" SelectText="Revoke role" />
                    </Columns>
                </asp:GridView>
     </div>
    <asp:Label class="text-centered" ID="LabelConfirm" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
