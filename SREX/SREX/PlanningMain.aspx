<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlanningMain.aspx.cs" Inherits="SREX.PlanningMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container text-center">
        <h1><i><b>Places That You Can Visit</b></i></h1>
        <br />
        <br />

        <div class="row">
            <div class="col-sm-4">
                <div class="thumbnail">
                    <asp:Image ID="SGZoo" runat="server" ImageUrl="~/Pictures/SingaporeZoo.jpg" Height="200px" Width="350px" />
                    <div class="caption">
                        <p></p>
                        <p>
                            <asp:Button ID="BtnZoo" runat="server" Text="Find More" class="btn-light" OnClick="BtnZoo_Click" />
                        </p>

                    </div>
                </div>
            </div>

            <div class="col-sm-4">
                <div class="thumbnail">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/NightSafari.jpg" Height="200px" Width="350px" />
                    <div class="caption">
                        <p></p>
                        <p>
                            <asp:Button ID="BtnNightSafari" runat="server" Text="Find More" class="btn-light" OnClick="BtnNightSafari_Click" />
                        </p>

                    </div>
                </div>
            </div>

            <div class="col-sm-4">
                <div class="thumbnail">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Pictures/RiverSafari.jfif" Height="200px" Width="350px" />
                    <div class="caption">
                        <p></p>
                        <p>
                            <asp:Button ID="BtnRiverSafari" runat="server" Text="Find More" class="btn-light" OnClick="BtnRiverSafari_Click" />
                        </p>

                    </div>
                </div>
            </div>

        </div>
        <br />
        <hr />
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
                    <h3>Self-Plan</h3>
                    <p>Plan Your Own Trip And Hope You Get Lost In Singapore</p>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
