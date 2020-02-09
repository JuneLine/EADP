<%@ Page Title="Edit Comment" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CommentEdit.aspx.cs" Inherits="SREX.CommentEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="well text-center">
        <h2>Edit Comment</h2>
    </div>
    <div class="well">
        <div class="row">
            <div class="form-group col-sm-8">
                <label for="tbName">Username: <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fill In Your Name" ControlToValidate="EditName">*</asp:RequiredFieldValidator></label>
                <asp:TextBox runat="server" ID="EditName" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-sm-4">
                <div class="row">
                    <label for="tbRating">Ratings: <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Fill In Your Name" ControlToValidate="EditRating">*</asp:RequiredFieldValidator> </label>
                    <div class="row">
                        <div class="col-sm-10">
                            <input type="number" id="EditRating" max="10" min="0" runat="server" class="form-control" />
                        </div>                        
                        <div class="col-sm-2">
                            <h4>/ 10</h4>
                        </div>
                    </div>                    
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <label for="tbComment">Comment: <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Fill In Your Name" ControlToValidate="EditComment">*</asp:RequiredFieldValidator></label>
                <asp:TextBox runat="server" ID="EditComment" CssClass="form-control" TextMode="MultiLine" Rows="8"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="text-center">
        <asp:Button runat="server" ID="BackToReviews" OnClick="BackToReviews_Click" CssClass="btn btn-default" Text="Back" />
        <asp:Button runat="server" ID="btnUpdate" OnClick="btnUpdate_Click" CssClass="btn btn-primary" Text="Confirm" />
    </div>
</asp:Content>
