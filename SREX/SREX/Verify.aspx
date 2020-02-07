<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="SREX.Verify" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="well" style="height: 64%; width: 36%; margin: 10% auto 0 auto">
        <div class="text-center">
            <asp:Image runat="server" ImageUrl="Profile.png" Height="20%" Width="20%" />
        </div>
        <div class="text-center">
            <label>SREX</label>
        </div>
        <br />
        <br />
        <div class="text-center" runat="server" id="success">
            <p>
                You have successfully activiated your account
            </p>
            <p>Your will be automatically redirected in 5 Seconds</p>
            <p>Click here to manually redirect <a href="Login">here</a></p>
        </div>
        <div class="text-center" runat="server" id="failure">
            <p>
                Error activiting account
            </p>
        </div>
    </div>
</asp:Content>
