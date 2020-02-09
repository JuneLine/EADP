<%@ Page Title="PageReview" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="SREX.Review" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <br />
    <div class="well text-center">
        <h2>Page Review</h2>
    </div>
    <br />
    <div class="container body-container-own" style="background-image: linear-gradient(to bottom, aliceblue, skyblue, aliceblue); border-radius:25px">
        <br />
        <div class="text-center">
            <input type="button" runat="server" id="btnAddComment" class="btn btn-primary" value="Add Comment" data-toggle="modal" data-target="#AddComment" />
            <p runat="server" id="promptlogin"><a href="Login">Login Here To Enter Comments</a></p>
        </div>
        <br />
        <asp:DataList runat="server" ID="dlComments" RepeatLayout="Flow">
            <ItemTemplate>
                <div class="row">
                    <div class="col-sm-1"></div>
                    <div class="well col-sm-10">
                        <div class="col-sm-1"></div>
                        <div class="col-sm-1">
                            <asp:Label runat="server" Text='<%# Eval("userName") %>'></asp:Label>
                        </div>
                        <div class="col-sm-8">
                            <asp:TextBox runat="server" ID="commentbox" Text='<%# Bind("comments") %>' TextMode="MultiLine" Rows="5" Width="100%" Enabled="false" Style="padding: 1%;" ReadOnly="True" />
                            Comment Made on : <%#Eval("date") %>
                            <p style="float: right;" runat="server" visible='<%#Eval("IsMe")%>'>
                                <button runat="server" value='<%#Eval("id") %>' id="btnOpenEditPanel" class="btn btn-default" onserverclick="btnOpenEditPanel_Click">Edit</button>
                            </p>
                        </div>
                        <div class="col-sm-2">
                            Ratings:
                        <br />
                            <%#Eval("rating") %> / 10.0
                        </div>
                    </div>
                    <div class="col-sm-1"></div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>

    <div class="modal fade" id="AddComment" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" style="margin-top: 10%;" role="document">
            <div class="modal-content form">
                <div class="modal-header text-center">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                    <h3 class="modal-title">Comment</h3>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="form-group col-sm-8">
                            <label for="tbName">Username: </label>
                            <asp:TextBox runat="server" ID="tbName" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group col-sm-4">
                            <div class="row">
                                <label for="tbRating">Ratings: </label>
                                <div class="row">
                                    <div class="col-sm-7">
                                        <input type="number" id="rating" max="10" min="0" runat="server" class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <span style="font-size: 1.3em">/10</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group row">
                        <div class="col-sm-12">
                            <label for="tbComment">Comment: </label>
                            <asp:TextBox runat="server" ID="tbComment" CssClass="form-control" TextMode="MultiLine" Rows="8"></asp:TextBox>
                        </div>
                    </div>
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button runat="server" ID="btnComment" class="btn btn-primary" Text="Comment" Style="float: right" OnClick="btnComment_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
