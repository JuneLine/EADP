<%@ Page Title="PageReview" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="SREX.Review" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="well text-center">
        <h2>Page Review</h2>
    </div>
    <div class="container well">
        <br />
        <div class="text-center">
            <input type="button" id="btnAddComment" class="btn btn-primary" value="Add Comment" data-toggle="modal" data-target="#AddComment" />
        </div>
        <br />
        <div class="row well">
            <div class="col-sm-1"></div>
            <div class="col-sm-1">
                <h5><b>
                    <asp:Label runat="server" ID="LblCommentBy">JuneLine</asp:Label></b></h5>
            </div>
            <div class="col-sm-9">
                <asp:TextBox runat="server" ID="tbCommentMade" CssClass="form-control" TextMode="MultiLine" Rows="3" Enabled="false"></asp:TextBox>
            </div>
            <div class="col-sm-1"></div>
        </div>
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
                    <div class="form-group col-sm-8">
                        <label for="tbName">Username </label>
                        <asp:TextBox runat="server" ID="tbName" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group col-sm-4">
                        <div class="row">
                            <label for="tbRating">Ratings </label>
                        </div>
                        <div class="row">
                            <div class="col-sm-7">
                                <asp:TextBox runat="server" ID="tbRating" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-sm-2">
                                <span style="font-size:1.3em">/10</span>
                            </div>
                        </div>
                    </div>
                    <div class="form-group col-sm-12">
                        <label for="tbComment">Comment: </label>
                        <asp:TextBox runat="server" ID="tbComment" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
                    </div>               
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>


                </div>
            </div>
        </div>
    </div>
</asp:Content>
