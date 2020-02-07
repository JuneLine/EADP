<%@ Page Title="Plan" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlanningMain.aspx.cs" Inherits="SREX.PlanningMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <br />
    <div class="row col-sm-12 col-lg-12 text-center">
        <asp:Label CssClass="text-center" ID="LabelError2" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div class="thumbnail text-center" id="reviewBox" style="margin: 1.5%" runat="server">
        <div class="caption">
            <h4>Your application is currently under review</h4>
        </div>
    </div>
    <div class="thumbnail text-center" id="joinUsBox" style="margin: 1.5%" runat="server">
        <div class="caption">
            <h4>Interested in joining us as a tourguide?</h4>
            <p>Click below!</p>
            <input type="button" runat="server" value="Join us!" class="btn btn-primary" data-toggle="modal" data-target="#confirmModal" OnClick="ApplyGuide_Click" />
        </div>
    </div>
    <div class="modal fade" id="confirmModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel2" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel2">Confirmation</h5>
                       
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    Interested to join us an a tour guide? Click below!
                    <br />
                    <label for="FileUpload1">Resume: </label> <asp:FileUpload runat="server" ID="FileUpload1" CssClass="form-control"/>
                    <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
                </div>
                <div class="card-body">
                   <p class="card-text">Interested in joining us as a tour guide? Click here!</p>
                    <asp:Button runat="server" ID="ApplyGuide" Text="Join us!" CssClass="btn btn-primary" OnClick="ApplyGuide_Click"/>
                </div>
            </div>
        <br />

    </div>
        </div>
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
        <div class="row">
            <div class="text-center col-sm-6" id="forTourGuide" runat="server">
                <a href="TourGuide">
                    <i class="fa fa-user planIcons"></i>
                </a>
                <h3>Tour guides</h3>
                <p>Come here to view plans you can guide!</p>
            </div>
            <div class="text-center col-sm-6" id="forAdminApply" runat="server">
                <a href="AdminApplication">
                    <i class="fa fa-bell planIcons"></i>
                </a>
                <h3>Applications</h3>
                <p>Click here to review applications</p>
            </div>
        </div>
        <hr />
        <br />

        <h2><i><b>Places That You Can Visit</b></i></h2>
        <br />
        <div>
            <asp:DataList runat="server" ID="DataListAttractions" RepeatColumns="2">
                <ItemTemplate>
                    <div class="thumbnail" style="margin: 1.5%">
                        <asp:Image runat="server" ImageUrl='<%# String.Format("Pictures/{0}", Eval("Picture") ) %>' Height="300px" Width="550px"/>
                        <div class="caption">
                            <h4><%#Eval("AttractionName") %></h4>
                            <p><%#Eval("Description") %></p>
                            <button class="btn btn-info">
                                <a href="<%#Eval("URL") %>">Find out more</a>
                            </button>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>

            <asp:DataList runat="server" ID="DataListAttractionsAdmin" RepeatColumns="2" Visible="false">
                <ItemTemplate>
                    <div class="thumbnail" style="margin: 1.5%">
                        <asp:Image runat="server" ImageUrl='<%# String.Format("Pictures/{0}", Eval("Picture") ) %>' Height="300px" Width="550px"/>
                        <div class="caption">
                            <h4><%#Eval("AttractionName") %></h4>
                            <p><%#Eval("Description") %></p>
                            <button class="btn btn-info">
                                <a href="<%#Eval("URL") %>">Find out more</a>
                            </button>
                                <a href="EditAttraction?AttractionId=<%#Eval("Id")%>" id="EditAttractionbtn" class="EditAttraction glyphicon glyphicon-option-vertical"></a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
        <br />
        <input type="button" id="btnAddPlace" class="btn btn-primary addEvents" value="Add Places" data-toggle="modal" data-target="#AddAttraction" runat="server"/>
    </div>
    <div class="modal fade" id="AddAttraction" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" style="margin-top: 10%;" role="document">
            <div class="modal-content form">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                    <h3 class="modal-title" id="exampleModalLabel">New Place</h3>
                </div>
                <div class="modal-body" style="width: 80%; margin: auto;">
                    <div class="form-group">
                        <label for="AttractionName">Name: </label>
                        <asp:TextBox runat="server" ID="AttractionName" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div>
                        <label for="AttractionPicture">Picture: </label>
                        <asp:FileUpload runat="server" ID="AttractionPicture" />
                    </div>
                    <br />
                    <div class="form-group">
                        <label for="AttractionURL">Website URL: </label>
                        <asp:TextBox runat="server" ID="AttractionsURL" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="AttractionDescription">Description: </label>
                        <asp:TextBox runat="server" ID="AttractionDescription" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="AttractionTags">Tag: </label>
                        <asp:TextBox runat="server" ID="AttractionTags" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="AttractionPrice">Price: </label>
                        <asp:TextBox runat="server" ID="AttractionPrice" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button runat="server" ID="AddNewAttraction" Text="Add Confirm" CssClass="btn btn-primary" OnClick="AddNewAttraction_Click"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
