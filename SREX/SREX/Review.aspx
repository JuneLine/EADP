<%@ Page Title="PageReview" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="SREX.Review" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="well text-center">
        <h2>Page Review</h2>
    </div>
    <div class="container well body-container-own">
        <br />
        <div class="text-center">
            <input type="button" runat="server" id="btnAddComment" class="btn btn-primary" value="Add Comment" data-toggle="modal" data-target="#AddComment" />
            <p runat="server" id="promptlogin"><a href="Login">Login Here To Enter Comments</a></p>
        </div>
        <br />
        <asp:DataList runat="server" ID="dlComments" RepeatLayout="Table" CssClass="table">
            <ItemTemplate>
                <div class="row well">
                    <div class="col-sm-1"></div>
                    <div class="col-sm-1">
                        <asp:Label runat="server" Text='<%# Eval("userName") %>'></asp:Label><br />
                    </div>
                    <div class="col-sm-8">
                        <asp:TextBox runat="server" ID="commentbox" Text='<%# Bind("comments") %>' TextMode="MultiLine" Rows="3" Width="100%" Enabled="false" />
                    </div>
                    <div class="col-sm-2">
                        Ratings:
                        <br />
                        <%#Eval("rating") %> / 10.0
                    </div>
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
                            <label for="tbName">Username </label>
                            <asp:TextBox runat="server" ID="tbName" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group col-sm-4">
                            <div class="row">
                                <label for="tbRating">Ratings </label>
                                <div class="row">
                                    <div class="col-sm-7">
                                        <asp:TextBox runat="server" ID="tbRating" CssClass="form-control" TextMode="Number"></asp:TextBox>
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
