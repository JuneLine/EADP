<%@ Page Title="Plan" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlanningMain.aspx.cs" Inherits="SREX.PlanningMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container text-center">
        <h1><i><b>Plan</b></i></h1>
        <br />
        <br />
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-6 text-center leaveSpace">
                    <a href="#">
                        <i class="fa fa-clipboard planIcons"></i>
                    </a>
                    <h3>Guide Tour</h3>
                    <p>Join Us In A Day Tour And Enjoy Your Time In Singapore</p>
                </div>
                <div class="col-sm-6 text-center leaveSpace">
                    <a href="SelfPlanMain">
                        <i class="fa fa-list planIcons"></i>
                    </a>
                    <h3>Self-Planning</h3>
                    <p>Plan Your Own Trip And Enjoy Your Free Roam</p>
                </div>
            </div>
        </div>

        <br />
        <hr />
        <br />

        <h2><i><b>Places That You Can Visit</b></i></h2>
        <br />

        <div class="row">
            <div class="col-sm-4">
                <div class="thumbnail">
                    <asp:Image ID="SGZoo" runat="server" ImageUrl="~/Pictures/SingaporeZoo.jpg" Height="220px" Width="450px" />
                    <div class="caption">
                        <h4>Singapore Zoo</h4>
                        <p></p>
                        <p>
                            <asp:Button ID="BtnZoo" runat="server" Text="Find More" class="btn btn-info" OnClick="BtnZoo_Click" />
                        </p>
                    </div>
                </div>
                <div class="thumbnail">
                    <asp:Image ID="JBP" runat="server" ImageUrl="~/Pictures/JurongBirdPark.jpg" Height="220px" Width="450px" />
                    <div class="caption">
                        <h4>Jurong Bird Park</h4>
                        <p></p>
                        <p>
                            <asp:Button ID="BtnJBP" runat="server" Text="Find More" class="btn btn-info" OnClick="BtnJBP_Click" />
                        </p>
                    </div>
                </div>
            </div>

            <div class="col-sm-4">
                <div class="thumbnail">
                    <asp:Image ID="NightSafari" runat="server" ImageUrl="~/Pictures/NightSafari.jpg" Height="220px" Width="450px" />
                    <div class="caption">
                        <h4>Night Safari</h4>
                        <p></p>
                        <p>
                            <asp:Button ID="BtnNightSafari" runat="server" Text="Find More" class="btn btn-info" OnClick="BtnNightSafari_Click" />
                        </p>
                    </div>
                </div>
                <div class="thumbnail">
                    <asp:Image ID="GBTB" runat="server" ImageUrl="~/Pictures/GBTB.jpg" Height="220px" Width="450px" />
                    <div class="caption">
                        <h4>Gardens By The Bay</h4>
                        <p></p>
                        <p>
                            <asp:Button ID="BtnGBTB" runat="server" Text="Find More" class="btn btn-info" OnClick="BtnGBTB_Click" />
                        </p>
                    </div>
                </div>
            </div>

            <div class="col-sm-4">
                <div class="thumbnail">
                    <asp:Image ID="RiverSafari" runat="server" ImageUrl="~/Pictures/RiverSafari.jfif" Height="220px" Width="450px" />
                    <div class="caption">
                        <h4>River Safari</h4>
                        <p></p>
                        <p>
                            <asp:Button ID="BtnRiverSafari" runat="server" Text="Find More" class="btn btn-info" OnClick="BtnRiverSafari_Click" />
                        </p>
                    </div>
                </div>
                <div class="thumbnail">
                    <asp:Image ID="USS" runat="server" ImageUrl="~/Pictures/USS.jpg" Height="220px" Width="450px" />
                    <div class="caption">
                        <h4>Universal Studios Singapore</h4>
                        <p></p>
                        <p>
                            <asp:Button ID="BtnUSS" runat="server" Text="Find More" class="btn btn-info" OnClick="BtnUSS_Click" />
                        </p>
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
