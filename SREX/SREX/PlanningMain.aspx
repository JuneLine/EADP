<%@ Page Title="Plan" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlanningMain.aspx.cs" Inherits="SREX.PlanningMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
<%--    <img src="/Pictures/NiceSGSkyline.jpg" height="95%" width="95%" style="margin-left: 2.5%; margin-right: 2.5%;" />--%>
    <div class="container text-center body-container-own">
        <br />
        <br />
        <div class="row">
            <div class="col-sm-6 text-center">
                <a href="GuidedTour">
                    <i class="fa fa-clipboard planIcons"></i>
                </a>
                <h3>Guide Tour</h3>
                <p>Join Us In A Day Tour And Enjoy Your Time In Singapore</p>
            </div>
            <div class="col-sm-6 text-center">
                <a href="SelfPlanMain">
                    <i class="fa fa-list planIcons"></i>
                </a>
                <h3>Self-Planning</h3>
                <p>Plan Your Own Trip And Enjoy Your Free Roam</p>
            </div>
        </div>
        <hr />
        <br />

        <h2><i><b>Places That You Can Visit</b></i></h2>
        <br />

        <div class="row">
            <div class="col-sm-6">
                <div class="thumbnail">
                    <asp:Image ID="SGZoo" runat="server" ImageUrl="~/Pictures/SingaporeZoo.jpg" Height="300px" Width="550px" />
                    <div class="caption">
                        <h4>Singapore Zoo</h4>
                        <p>Singapore Zoo, an open, learning experience about wildlife</p>
                        <asp:Button ID="BtnZoo" runat="server" Text="Click To Find More" class="btn btn-info" OnClick="BtnZoo_Click" />
                    </div>
                </div>
                <div class="thumbnail">
                    <asp:Image ID="JBP" runat="server" ImageUrl="~/Pictures/JurongBirdPark.jpg" Height="300px" Width="550px" />
                    <div class="caption">
                        <h4>Jurong Bird Park</h4>
                        <p>Jurong Bird Park, Where Birds command the Mastery of the Sky</p>
                        <asp:Button ID="BtnJBP" runat="server" Text="Click To Find More" class="btn btn-info" OnClick="BtnJBP_Click" />

                    </div>
                </div>
                <div class="thumbnail">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/RiverSafari.jfif" Height="300px" Width="550px" />
                    <div class="caption">
                        <h4>River Safari</h4>
                        <p>River Safari, The One and Only River-Themed Wildlife Park</p>
                        <asp:Button ID="Button1" runat="server" Text="Click To Find More" class="btn btn-info" OnClick="BtnRiverSafari_Click" />
                    </div>
                </div>
            </div>

            <div class="col-sm-6">
                <div class="thumbnail">
                    <asp:Image ID="NightSafari" runat="server" ImageUrl="~/Pictures/NightSafari.jpg" Height="300px" Width="550px" />
                    <div class="caption">
                        <h4>Night Safari</h4>
                        <p>Night Safari, Explore the Kingdom Of Nocturnal Animals</p>
                        <asp:Button ID="BtnNightSafari" runat="server" Text="Click To Find More" class="btn btn-info" OnClick="BtnNightSafari_Click" />
                    </div>
                </div>
                <div class="thumbnail">
                    <asp:Image ID="GBTB" runat="server" ImageUrl="~/Pictures/GBTB.jpg" Height="300px" Width="550px" />
                    <div class="caption">
                        <h4>Gardens By The Bay</h4>
                        <p>Gardens By The Bay, The Green Plant Kingdom</p>
                        <asp:Button ID="BtnGBTB" runat="server" Text="Click To Find More" class="btn btn-info" OnClick="BtnGBTB_Click" />
                    </div>
                </div>
                <div class="thumbnail">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Pictures/ResortWorldSentosa.jpg" Height="300px" Width="550px" />
                    <div class="caption">
                        <h4>Resort World Sentosa</h4>
                        <p>Resort World Sentosa, A place with Fun And Laughter</p>
                        <asp:Button ID="Button2" runat="server" Text="Click To Find More" class="btn btn-info" OnClick="BtnUSS_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
