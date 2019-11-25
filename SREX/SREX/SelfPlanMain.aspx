<%@ Page Title="SelfPlanner" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelfPlanMain.aspx.cs" Inherits="SREX.SelfPlanMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/selfPlan.css" rel="stylesheet" />
    <div class="container">
            <div class="page-header well">
                <h1 class="text-center">Self plan</h1>
            </div>
    </div>
    <div class="container plans">
            <div class="col-sm-4 col-lg-4 destinationyourmother">

                    <div class="input-group col-sm-12 col-lg-12">
                        <input type="text" class="form-control" placeholder="Search for...">
                        <span class="input-group-btn">
                            <button class="btn btn-default" type="button">Go!</button>
                        </span>
                    </div>

                <br />
                    <div class="destinationOne">
                        <a href="#">
                            <div class="thumbnail">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/JurongBirdPark.jpg" Height="220px" Width="320px" />
                                <div class="caption">
                                    <h4>Botanic Gardens</h4>
                                    <p></p>
                                        <div class="extraDes">
                                            Description: A place with Flowers
                                        </div>
                                        <div class="extraCost">
                                            Price: F.O.C
                                        </div>
                                        <div class="extraTags">
                                            <h6><span class="badge badge-secondary">Outdoors</span></h6>
                                        </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="destinationTwo">
                        <a href="#">
                            <div class="thumbnail">
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/Pictures/SingaporeZoo.jpg" Height="220px" Width="320px" />
                                <div class="caption">
                                    <h4>Singapore Zoological Gardens</h4>
                                    <p></p>
                                        <div class="extraDes">
                                            Description: A place with Animals
                                        </div>
                                        <div class="extraCost">
                                            Price: $30 per pax
                                        </div>
                                        <div class="extraTags">
                                            <h6><span class="badge badge-secondary">Animals</span></h6>
                                        </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="destinationThree">
                        <a href="#">
                            <div class="thumbnail">
                                <asp:Image ID="Image3" runat="server" ImageUrl="~/Pictures/ResortWorldSentosa.jpg" Height="220px" Width="320px" />
                                <div class="caption">
                                    <h4>Resort World Sentosa</h4>
                                    <p></p>
                                        <div class="extraDes">
                                            Description: A place with Sandtosa
                                        </div>
                                        <div class="extraCost">
                                            Price: F.O.C
                                        </div>
                                        <div class="extraTags">
                                            <h6><span class="badge badge-secondary">Indoors</span></h6>
                                        </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="destinationOne">
                        <a href="#">
                            <div class="thumbnail">
                                <asp:Image ID="JBP" runat="server" ImageUrl="~/Pictures/ScienceCentre.jpg" Height="220px" Width="320px" />
                                <div class="caption">
                                    <h4>Science Centre</h4>
                                    <p></p>
                                        <div class="extraDes">
                                            Description: A place with Science
                                        </div>
                                        <div class="extraCost">
                                            Price: $10
                                        </div>
                                        <div class="extraTags">
                                            <h6><span class="badge badge-secondary">Indoors</span></h6>
                                        </div>
                                </div>
                            </div>
                        </a>
                    </div>

            </div>
            <br />
            <div class="col-sm-8 col-lg-8 table-bordered">
                <div class="row">
                    <div class="form-group col-sm-10 col-lg-10">
                        <label for="selfPlanTitle">Title</label>
                        <input type="text" class="form-control" id="selfPlanTitle" aria-describedby="SelfPlanTitle" placeholder="Enter title">
                        <small id="titleHelp" class="form-text text-muted">If left blank, title will be named as untitled</small>
                    </div>
                    <div class="col-sm-2 col-lg-2" style="padding:2%;">
                        <button type="button" class="btn btn-primary" style="float:right;margin: 1%" onclick="window.location.href='PlanningHistory.aspx'">History</button>
                    </div>
                  </div>
                <div class="row">
                    <div class="col-sm-3 col-lg-3" style="padding:2%;">
                        Plan for selected date:
                        <input type="date" value="">
                    </div>
                    <div class="col-sm-5 col-lg-5" style="padding:2%;">
                        Would you like to hire a tour guide?
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server" CellSpacing="5" RepeatDirection="Horizontal">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:RadioButtonList>
                    </div>
                 </div>
                <hr />
                <div class="row rounded">
                    <table class="table">
                        <thead class="thead-dark">
                            <tr>
                                <th scope="col" class="col-sm-4 col-lg-4">Timings</th>
                                <th scope="col" class="col-sm-8 col-lg-8">Activities</th>
                            </tr>
                        </thead>
                        <tbody>
                        <tr>
                            <th scope="row">10am - 11am</th>
                            <td colspan="4">
                                <p>
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                        <asp:ListItem>Botanic Gardens</asp:ListItem>
                                        <asp:ListItem>Singapore Zoological Garden</asp:ListItem>
                                        <asp:ListItem>Resort Worlds Sentosa</asp:ListItem>
                                        <asp:ListItem>Science Centre</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">11am - 12am</th>
                            <td colspan="4">
                                <p>
                                    <asp:DropDownList ID="DropDownList2" runat="server">
                                        <asp:ListItem>Botanic Gardens</asp:ListItem>
                                        <asp:ListItem>Singapore Zoological Garden</asp:ListItem>
                                        <asp:ListItem>Resort Worlds Sentosa</asp:ListItem>
                                        <asp:ListItem>Science Centre</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">12am - 1pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:DropDownList ID="DropDownList3" runat="server">
                                        <asp:ListItem>Botanic Gardens</asp:ListItem>
                                        <asp:ListItem>Singapore Zoological Garden</asp:ListItem>
                                        <asp:ListItem>Resort Worlds Sentosa</asp:ListItem>
                                        <asp:ListItem>Science Centre</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">1pm - 2pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:DropDownList ID="DropDownList4" runat="server">
                                        <asp:ListItem>Botanic Gardens</asp:ListItem>
                                        <asp:ListItem>Singapore Zoological Garden</asp:ListItem>
                                        <asp:ListItem>Resort Worlds Sentosa</asp:ListItem>
                                        <asp:ListItem>Science Centre</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">2pm - 3pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:DropDownList ID="DropDownList5" runat="server">
                                        <asp:ListItem>Botanic Gardens</asp:ListItem>
                                        <asp:ListItem>Singapore Zoological Garden</asp:ListItem>
                                        <asp:ListItem>Resort Worlds Sentosa</asp:ListItem>
                                        <asp:ListItem>Science Centre</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">3pm - 4pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:DropDownList ID="DropDownList6" runat="server">
                                        <asp:ListItem>Botanic Gardens</asp:ListItem>
                                        <asp:ListItem>Singapore Zoological Garden</asp:ListItem>
                                        <asp:ListItem>Resort Worlds Sentosa</asp:ListItem>
                                        <asp:ListItem>Science Centre</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">4pm - 5pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:DropDownList ID="DropDownList7" runat="server">
                                        <asp:ListItem>Botanic Gardens</asp:ListItem>
                                        <asp:ListItem>Singapore Zoological Garden</asp:ListItem>
                                        <asp:ListItem>Resort Worlds Sentosa</asp:ListItem>
                                        <asp:ListItem>Science Centre</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">5pm - 6pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:DropDownList ID="DropDownList8" runat="server">
                                        <asp:ListItem>Botanic Gardens</asp:ListItem>
                                        <asp:ListItem>Singapore Zoological Garden</asp:ListItem>
                                        <asp:ListItem>Resort Worlds Sentosa</asp:ListItem>
                                        <asp:ListItem>Science Centre</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">6pm - 7pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:DropDownList ID="DropDownList9" runat="server">
                                        <asp:ListItem>Botanic Gardens</asp:ListItem>
                                        <asp:ListItem>Singapore Zoological Garden</asp:ListItem>
                                        <asp:ListItem>Resort Worlds Sentosa</asp:ListItem>
                                        <asp:ListItem>Science Centre</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">7pm - 8pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:DropDownList ID="DropDownList10" runat="server">
                                        <asp:ListItem>Botanic Gardens</asp:ListItem>
                                        <asp:ListItem>Singapore Zoological Garden</asp:ListItem>
                                        <asp:ListItem>Resort Worlds Sentosa</asp:ListItem>
                                        <asp:ListItem>Science Centre</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                            </td>
                        </tr>
                        </tbody>
                    </table>
                    <hr />
                    <button type="button" class="btn btn-primary" style="float:right;margin: 1%" onclick="window.location.href='SelfPlanConfirmation.aspx'">Submit</button>
                </div>
            </div>
        </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
