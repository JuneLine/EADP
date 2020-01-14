<%@ Page Title="Plan" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlanningMain.aspx.cs" Inherits="SREX.PlanningMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
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
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button runat="server" ID="AddNewAttraction" Text="Add Confirm" CssClass="btn btn-primary" OnClick="AddNewAttraction_Click" style="display:none;"/>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
