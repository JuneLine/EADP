<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TourGuide.aspx.cs" Inherits="SREX.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
            <div class="page-header well">
                <h1 class="text-center">Available Tours for you to guide!</h1>
            </div>
    </div>
    <div class="col-sm-12 col-lg-12 text-center" style="padding:2%;" runat="server">
        <asp:GridView ID="GvTD" runat="server" AutoGenerateColumns="False" Height="120px" Width="100%" CssClass="table table-striped" OnSelectedIndexChanged="GvTD_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="UniqueId" HeaderText="UniqueId"/>
                        <asp:BoundField DataField="UserName" HeaderText="Username"/>
                        <asp:BoundField DataField="Title" HeaderText="Title" />
                        <asp:BoundField DataField="Date" HeaderText="Date"/>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
     </div>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
