﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminApplication.aspx.cs" Inherits="SREX.AdminApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
            <div class="page-header well">
                <h1 class="text-center">Tour Guide applications</h1>
            </div>
    </div>
    <div class="col-sm-12 col-lg-12 text-center" style="padding:2%;" runat="server">
        <asp:GridView ID="GvTD" runat="server" AutoGenerateColumns="False" Height="120px" Width="100%" CssClass="table table-striped" OnSelectedIndexChanged="GvTD_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="UniqueId" HeaderText="ID"/>
                        <asp:BoundField DataField="UserName" HeaderText="Username"/>
                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        <asp:BoundField DataField="EmailAddr" HeaderText="EmailAddr"/>
                        <asp:CommandField ShowSelectButton="True" SelectText="Approve" />
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
