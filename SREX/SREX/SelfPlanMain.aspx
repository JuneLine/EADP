﻿<%@ Page Title="SelfPlanner" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelfPlanMain.aspx.cs" Inherits="SREX.SelfPlanMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/selfPlan.css" rel="stylesheet" />
    <br />
    <nav class="navbar navbar-inverse bg-light" style="margin-bottom:0px;">
        <a class="navbar-brand active" href="SelfPlanMain">Plan your tours here!</a>
        <a class="navbar-brand" href="planningHistory">View your created plans</a>
    </nav>
    <div class="jumbotron" style="margin: 0px;">
                <h1 class="text-center">SelfPlan</h1>
        <p class="lead text-center">Create your very own itinery here!</p>
    </div>
    <br />
    <div class="container plans">
            <div class="col-sm-4 col-lg-4 destinationyourmother">
                    <div class="input-group col-sm-12 col-lg-12">
                        <asp:TextBox ID="TbSearch" class="form-control" placeholder="Search for..." runat="server"></asp:TextBox>
                        <span class="input-group-btn">
                            <asp:Button ID="ButtonSearchName" runat="server" Text="Go!" class="btn btn-default" OnClick="ButtonSearchName_Click"/>
                        </span>
                    </div>
                <div class="col-sm-12 col-lg-12" style="padding:2%;" id="Div1" runat="server">
                            <asp:Button ID="ButtonAll" class="btn btn-primary" style="float:right;margin: 1%; width: 100%" runat="server" Text="View all" OnClick="ButtonAll_Click"/>
                    </div>
                <br />
                <div class="col-sm-12 col-lg-12" style="padding:2%;" runat="server">
                    
                    <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <div class="destinationOne">
                        <a href="#">
                            <div class="thumbnail">
                                <asp:Image ID="Image1" runat="server" style="margin-right:0px;margin-left:0px;height:220px;width:320px" ImageUrl='<%# String.Format("Pictures/{0}", Eval("Picture") ) %>'/>
                                <div class="caption">
                                    <h4><%#Eval("AttractionName") %></h4>
                                    <p></p>
                                        <div class="extraDes">
                                            Description: <%#Eval("Description") %>
                                        </div>
                                        <div class="extraCost">
                                            Price: <%#Eval("Price") %>
                                        </div>
                                        <div class="extraTags">
                                            <h6><span class="badge badge-secondary"><%#Eval("Tags") %></span></h6>
                                        </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    </ItemTemplate>
                </asp:DataList>

                    <div class="text-center">
                        <asp:Label ID="LabelNothing" runat="server" Text="" CssClass="text-center" style="text-align:center;"></asp:Label>
                    </div>
                    </div>
            </div>
            <br />
            <div class="col-sm-8 col-lg-8 table-bordered">
                <div class="row">
                    <div class="form-group col-sm-10 col-lg-10">
                        <label for="selfPlanTitle">Title</label>
                        <asp:TextBox ID="SelfPlanTitle" class="form-control" aria-describedby="SelfPlanTitle" placeholder="Enter title" runat="server"></asp:TextBox>
                        <small id="titleHelp" class="form-text text-muted">If left blank, title will be named as untitled</small>
                    </div>
                   
                  </div>
                <div class="row">
                    <div class="col-sm-3 col-lg-3" style="padding:2%;">
                        Plan for selected date:
                        <asp:TextBox ID="SelfPlanDate" runat="server" placeholder="From" type="date" CausesValidation="True"></asp:TextBox>
                        <asp:Label ID="LabeError" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="col-sm-5 col-lg-5" style="padding:2%;">
                        Would you like to hire a tour guide?
                    <asp:RadioButtonList ID="RadioButtonHire" runat="server" CellSpacing="5" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" style="margin:10px;">Yes</asp:ListItem>
                        <asp:ListItem class="radio-inline" selected="True">No</asp:ListItem>
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
                                    <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name">
                                        <asp:ListItem>Botanic Gardens</asp:ListItem>
                                        <asp:ListItem>Singapore Zoological Garden</asp:ListItem>
                                        <asp:ListItem>Resort Worlds Sentosa</asp:ListItem>
                                        <asp:ListItem>Science Centre</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnStr %>" SelectCommand="SELECT [Name] FROM [TouristAttractions]"></asp:SqlDataSource>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnStr %>" SelectCommand="SELECT [name] FROM [Destination]"></asp:SqlDataSource>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">11am - 12am</th>
                            <td colspan="4">
                                <p>
                                    <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
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
                                    <asp:DropDownList ID="DropDownList3" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
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
                                    <asp:DropDownList ID="DropDownList4" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
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
                                    <asp:DropDownList ID="DropDownList5" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
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
                                    <asp:DropDownList ID="DropDownList6" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
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
                                    <asp:DropDownList ID="DropDownList7" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
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
                                    <asp:DropDownList ID="DropDownList8" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
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
                                    <asp:DropDownList ID="DropDownList9" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
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
                                    <asp:DropDownList ID="DropDownList10" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
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
                    <asp:Button ID="Button2" runat="server" Text="Submit" class="btn btn-primary" style="float:right;margin: 1%" OnClick="Button2_Click"/>
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
